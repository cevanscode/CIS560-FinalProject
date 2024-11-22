﻿using DataAccess;

namespace CIS560FinalProject
{
    class SqlAccountRepository : IAccountRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAccountRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Account CreateAccount(string username, string password, string email, string fullName, DateTime birthday)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(fullName));

            var d = new CreateAccountDataDelegate(username, password, email, fullName, birthday);
            return executor.ExecuteNonQuery(d);
        }

        //public Account FetchAccount(int accountID)
        //{
        //    var d = new FetchAccountDataDelegate(accountID);
        //    return executor.ExecuteReader(d);
        //}

        public Account FetchAccount(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            var d = new FetchAccountDataDelegate(username, password);
            return executor.ExecuteReader(d);
        }

        public Character GetCharacter(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            var talents = GetCharacterTalents(username, password);

            var d = new GetCharacterWithAccountDataDelegate(username, password, (List<Talent>)talents);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Talent> GetCharacterTalents(string username, string password)
        {
            return executor.ExecuteReader(new GetCharacterTalentsDataDelegate(username, password));
        }

        public IReadOnlyList<Account> RetrieveAccounts()
        {
            return executor.ExecuteReader(new RetrieveAccountsDataDelegate());
        }
    }
}
