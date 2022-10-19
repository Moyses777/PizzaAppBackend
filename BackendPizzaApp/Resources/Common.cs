using BackendPizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendPizzaApp.Resources
{
    public class Common
    {
        private static Common _instance = new Common();
        private Users _user;
        public static Common instance
        {
            get { return _instance; }
            set { if (_instance == null) _instance = new Common(); }
        }

        public void setUser(Users user)
        {
            _user = user;
        }

        public Users getUser()
        {
            return _user;
        }

        public void clearUser()
        {
            _user = null;
        }
    }
}
