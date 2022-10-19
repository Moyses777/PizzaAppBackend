using BackendPizzaApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendPizzaApp.Models.Builders
{
    #region Class CostumerBuilder
    /// <summary>
    /// This class creates and do actions of CostumersUser or Users with Costumer Role.
    /// </summary>
    /// <typeparam name="SELF"></typeparam>
    public class CostumerBuilder<SELF> : IBuilderUser<SELF> where SELF: CostumerBuilder<SELF>
    {
        #region Variebles from the class
        private Users _user;
        private string _job;
        private int _earning;

        public string Job { get { return _job; } }
        public int Earning { get { return _earning; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Building the CostumerBuilder constructor and Users constructor
        /// </summary>
        public CostumerBuilder()
        {
            _user = new Users();
        }
        #endregion

        #region Methods to set object (User)
        /// <summary>
        /// This method set Users Id and return a recursive class to set more props
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>SELF</returns>
        public SELF SetId(int Id)
        {
            this._user.Id = Id;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Lastname and return a recursive class to set more props
        /// </summary>
        /// <param name="Lastname"></param>
        /// <returns>SELF</returns>
        public SELF SetLastname(string Lastname)
        {
            this._user.Lastname = Lastname;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Name and return a recursive class to set more props
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>SELF</returns>
        public SELF SetName(string Name)
        {
            this._user.Name = Name;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Password and return a recursive class to set more props
        /// </summary>
        /// <param name="Password"></param>
        /// <returns>SELF</returns>
        public SELF SetPassword(string Password)
        {
            this._user.Password = Password;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Permitions and return a recursive class to set more props
        /// </summary>
        /// <param name="RangePermitions"></param>
        /// <returns>SELF</returns>
        public SELF SetRangePermitions(int RangePermitions)
        {
            this._user.RangePermitions = RangePermitions;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Telephone and return a recursive class to set more props
        /// </summary>
        /// <param name="Telephone"></param>
        /// <returns>SELF</returns>
        public SELF SetTelephone(string Telephone)
        {
            this._user.Telephone = Telephone;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Job and return a recursive class to set more props
        /// </summary>
        /// <param name="Job"></param>
        /// <returns>SELF</returns>
        public SELF SetJob(string Job)
        {
            this._job = Job;
            return (SELF) this;
        }

        /// <summary>
        /// This method set Users Earning and return a recursive class to set more props
        /// </summary>
        /// <param name="Earning"></param>
        /// <returns>SELF</returns>
        public SELF SetEarning(int Earning)
        {
            this._earning = Earning;
            return (SELF) this;
        }
        #endregion

        #region Method to build object
        /// <summary>
        /// This method return an User instance so you can Login, Logout or Register User
        /// </summary>
        /// <returns>Users</returns>
        public Users BuildToLog()
        {
            return _user;
        }

        /// <summary>
        /// This method return the CostumerBuilder Instance Finished.
        /// </summary>
        /// <returns>CostumerBuilder</returns>
        public CostumerBuilder<SELF> Build()
        {
            return this;
        }
        #endregion
    }
    #endregion
}
