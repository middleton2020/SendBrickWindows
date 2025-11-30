using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickWindows.Models
{
    class UserModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo {  get; set; }

        public UserModel()
        {

        }
        public UserModel(string userName)
        {
            UserName = userName;
        }
        public UserModel(string userName, string companyName)
        {
            UserName = userName;
            CompanyName = companyName;
        }
        public UserModel(string userName, string companyName, string companyLogo)
        {
            UserName = userName;
            CompanyName = companyName;
            CompanyLogo = companyLogo;
        }
        public UserModel(string userId, string userName, string companyName, string companyLogo)
        {
            UserId = userId;
            UserName = userName;
            CompanyName = companyName;
            CompanyLogo = companyLogo;
        }
    }
}
