using BackendPizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendPizzaApp.Resources
{
    #region Common class
    public class Common
    {
        #region Variables from the class
        private static Common _instance = new Common();
        private Users _user;
        /// <summary>
        /// This variable will help you to access to methods from this class in a static way
        /// </summary>
        public static Common instance
        {
            get { return _instance; }
            set { if (_instance == null) _instance = new Common(); }
        }
        #endregion

        #region Methods to set and get user
        /// <summary>
        /// This method is a setter from this class (user)
        /// </summary>
        /// <param name="user"></param>
        public void setUser(Users user)
        {
            _user = user;
        }

        /// <summary>
        /// this method is a getter from this class (user)
        /// </summary>
        /// <returns></returns>
        public Users getUser()
        {
            return _user;
        }

        /// <summary>
        /// this method clean the variable user
        /// </summary>
        public void clearUser()
        {
            _user = null;
        }
        #endregion
    }
    #endregion
}
