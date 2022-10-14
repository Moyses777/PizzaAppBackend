using BackendPizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendPizzaApp.Interfaces
{
    /// <summary>
    /// This interface will set all the users that you want to
    /// create so if you want to create a new user or userrole
    /// you must implement first this interface, 
    /// IMPORTANT: SELF is to do recursive constructors and that we
    /// can access to all the methods that you have implement.
    /// </summary>
    /// <typeparam name="SELF"></typeparam>
    public interface IBuilderUser<SELF>
    {
        SELF SetId(int Id);
        SELF SetName(string Name);
        SELF SetLastname(string Lastname);
        SELF SetPassword(string Password);
        SELF SetTelephone(string Telephone);
        SELF SetRangePermitions(int RangePermitions);
    }
}
