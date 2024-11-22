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
            {
                MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null!;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null!;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null!;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null!;
            }

            var d = new CreateAccountDataDelegate(username, password, email, fullName, birthday);
            return executor.ExecuteNonQuery(d);
        }

        public Account FetchAccount(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            var d = new FetchAccountDataDelegate(username, password);
            return executor.ExecuteReader(d);
        }


        public IReadOnlyList<Account> RetrieveAccounts()
        {
            return executor.ExecuteReader(new RetrieveAccountsDataDelegate());
        }
    }
}
