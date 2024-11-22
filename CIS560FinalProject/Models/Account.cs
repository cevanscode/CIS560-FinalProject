using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    /// <summary>
    /// Represents information about a user's account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The account's identifier
        /// </summary>
        public int AccountID {  get; set; }

        /// <summary>
        /// The account's Username
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// The account's Password
        /// </summary>
        public string? Password { get; set; }

        //public Byte[] BytePW { get; set; }

        /// <summary>
        /// The account's Email
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// The account's Full Name
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// If the account has admin level access
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// The account's Birthday
        /// </summary>
        public DateTime Birthday { get; set; }

        public Account(int accountID, string username, string password, string email, string fullName, DateTime birthday)
        {
            AccountID = accountID;
            Username = username;
            Password = password;
            Email = email;
            FullName = fullName;
            Birthday = birthday;
        }

        //public Account(int accountID, string username, Byte[] password, string email, string fullName, DateTime birthday)
        //{
        //    AccountID = accountID;
        //    Username = username;
        //    BytePW = password;
        //    Email = email;
        //    FullName = fullName;
        //    Birthday = birthday;
        //}
    }
}
