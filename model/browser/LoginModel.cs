using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketReverseShellDotNet.model.browser
{
    internal class LoginModel
    {

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? OriginalUrl { get; set; }
        public string? ActionUrl { get; set; }
        public string? DateCreated { get; set; }
        public string? DateLastUsed { get; set; }
        public string? BrowserProfile { get; set; }

        public LoginModel(string? Username, string? Password, string? Url,
            string? ActionUrl,string DateCreated, string? DateLastUsed,
            string? BrowserProfile)
        {
            this.Username = Username;
            this.Password = Password;
            this.OriginalUrl = Url;
            this.ActionUrl = ActionUrl;
            this.DateCreated = DateCreated;
            this.DateLastUsed = DateLastUsed;
            this.BrowserProfile = BrowserProfile;
        }

    }
}
