using CM.SendBrickWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendBrickWindows.Tools
{
    class CurrentUser
    {
        public UserModel UserRecord { get; set; }

        public bool IsLoggedIn()
        {
            return true;
        }

        public bool LogInUser(string inpUserName, string inpPassword)
        {
            UserRecord = new UserModel();
            UserRecord.CompanyName = "Bricks In Bloom";
            UserRecord.CompanyLogo = "/CompanyLogo.png";

            UserRecord.UserName = inpUserName;
            return true;
        }
    }
}
