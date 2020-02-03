using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeChat
{
    class LoginHelper
    {
        
     

        private static string user;
        private static bool isLoggedIn = false;
        private static bool hasSelected = false;
        private static string selectedUser = "";
        private static bool isAdmin = false;


        public static string User { get => user; set => user = value; }
        public static bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }
        public static bool HasSelected { get => hasSelected; set => hasSelected = value; }
        public static string SelectedUser { get => selectedUser; set => selectedUser = value; }
        public static bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
