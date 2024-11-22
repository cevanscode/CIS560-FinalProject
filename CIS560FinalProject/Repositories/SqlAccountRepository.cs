using DataAccess;

namespace CIS560FinalProject
{
    class SqlAccountRepository : IAccountRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAccountRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Account CreateAccount(string username, string password, string email, string fullName, DateTime birthday, bool isAdmin)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(fullName));

            var d = new CreateAccountDataDelegate(username, password, email, fullName, birthday, isAdmin);
            return executor.ExecuteNonQuery(d);
        }

        public Account FetchAccount(int accountID)
        {
            var d = new FetchAccountDataDelegate(accountID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Account> RetrieveAccounts()
        {
            return executor.ExecuteReader(new RetrieveAccountsDataDelegate());
        }
    }
}
