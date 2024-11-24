﻿using CIS560FinalProject.DataDelegates;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void DeleteAccount(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            var d = new DeleteAccountDataDelegate(username, password);
            executor.ExecuteNonQuery(d);
        }

        public void DeleteCharacter(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));
            var d = new DeleteCharacterDataDelegate(username, password);
            executor.ExecuteNonQuery(d);
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
