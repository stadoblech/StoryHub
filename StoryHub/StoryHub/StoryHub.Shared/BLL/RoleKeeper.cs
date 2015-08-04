using StoryHub.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.BLL
{
    /// <summary>
    /// Utilized class diagram v1
    /// </summary>
    public static class RoleKeeper
    {
        private static User _loggedUser = null;
        public static User LoggedUser
        {
            get { return _loggedUser; }
        }

        /// <summary>
        /// This method verifies connectivity with server. 
        /// </summary>
        /// <returns>If is possible to connect to server.</returns>
        private static bool verifyConnection() 
        {
            //stub
            return true;
        }

        /// <summary>
        /// This metod verifies user's email. If there is such email, method will return true.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>If is possible to find this email</returns>
        private static bool verifyEmail(string email)
        { 
            //stub - nutné použít šiforvaný přenos
            return true;
        }

        /// <summary>
        /// This metod verifies user's password. If there is such email with such password, method will return true.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>If is possible to find this email with this password.</returns>
        private static bool verifyPassword(string email, string password)
        { 
            //stub - nutné použít šifrovaný přenos
            return true;
        }

        /// <summary>
        /// This method verifies email and password. There is bool of success and string of error message as return value.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Success sign and message.</returns>
        public static Tuple<bool, string> Login(string email, string password) 
        {
            if (!verifyConnection())
                return new Tuple<bool, string>(false, "We cannot connect server right now.");
            else if (!verifyEmail(email))
                return new Tuple<bool, string>(false, "We cannot find such account.");
            else if (!verifyPassword(email, password))
                return new Tuple<bool, string>(false, "This is incorrect password.");
            else
            {
                //stub - get user
                _loggedUser = SampleDataCreator.TestUser1_Cendric; //testovací data
                
                return new Tuple<bool, string>(true, string.Empty);
            }
        }

        /// <summary>
        /// This method reverify user indipendence.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ReverifyPassword(string password)
        {
            return verifyPassword(_loggedUser.Email, password);
        }

    }
}
