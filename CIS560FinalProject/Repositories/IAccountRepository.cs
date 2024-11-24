﻿using System;

namespace CIS560FinalProject
{
    public interface IAccountRepository
    {
        /// <summary>
        /// Retrieves all accounts from the database
        /// </summary>
        /// <returns>List containing all accounts</returns>
        public IReadOnlyList<Account> RetrieveAccounts();

        /// <summary>
        /// Retrives an account from the database
        /// </summary>
        /// <param name="accountID">The id of the account to retrieve</param>
        /// <returns>The character</returns>
        // Account FetchAccount(int accountID);

        /// <summary>
        /// Creates an account in the repository
        /// </summary>
        /// <param name="userName">The account's username</param>
        /// <param name="password">The account's password</param>
        /// <param name="email">The account's email</param>
        /// <param name="fullName">The account holder's full name</param>
        /// <param name="birthday">The account holder's birthday</param>
        /// <returns>The created Account</returns>
        public Account CreateAccount(string userName, string password, string email, string fullName, DateTime birthday);

        public void DeleteAccount(string userName, string password);

        public void DeleteCharacter(string userName, string password);

        public Account FetchAccount(string username, string password);

        public Character GetCharacter(string userName, string password);

        public IReadOnlyList<Talent> GetCharacterTalents(string userName, string password);
    }
}
