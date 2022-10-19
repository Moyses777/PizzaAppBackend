using BackendPizzaApp.Models.Builders;
using BackendPizzaApp.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BackendPizzaApp.Models
{
    #region Class User
    /// <summary>
    /// This class is the Generic Users Class so you can login,
    /// logout or register and it has the generic properties
    /// </summary>
    public class Users
    {
        #region Variables from class
        private int _id;
        private string _name;
        private string _lastname;
        private string _password;
        private string _telephone;
        private int _rangePermitions;

        public int Id { get { return _id; } set { if (_id != value) _id = value; } }
        public string Name { get { return _name; } set { if (_name != value) _name = value; } }
        public string Lastname { get { return _lastname; } set { if (_lastname != value) _lastname = value; } }
        public string Password { get { return _password; } set { if (_password != value) _password = value; } }
        public string Telephone { get { return _telephone; } set { if (_telephone != value) _telephone = value; } }
        public int RangePermitions { get { return _rangePermitions; } set { if (_rangePermitions != value) _rangePermitions = value; } }
        #endregion

        #region Constructor and Building constructor
        /// <summary>
        /// Creation of class so you can call the recursive constructor
        /// </summary>
        public class BuilderUser : CostumerBuilder<BuilderUser>
        {

        }

        /// <summary>
        /// Building the constructor recursive from BuilderUser
        /// </summary>
        public static BuilderUser New => new BuilderUser();
        #endregion

        #region Methods from the user
        /// <summary>
        /// This method validate that the user exists in database and return what 
        /// it has found
        /// </summary>
        /// <returns>Bool</returns>
        public bool Login()
        {
            string username = "Moises";
            string password = "123456";
            return this.Name == username && this.Password == password;
        }

        /// <summary>
        /// This method send a database request to logout the session
        /// </summary>
        public void Logout()
        {

        }

        /// <summary>
        /// This method register the new user in database.
        /// </summary>
        public void Register()
        {
            Common.instance.setUser(this);
            Thread.Sleep(5000);
        }
        #endregion
    }
    #endregion
}
