using CIS560FinalProject;
using DataAccess;

internal class FetchAccountDataDelegate : DataReaderDelegate<Account>
{
    private readonly string username;
    private readonly string password;

    public FetchAccountDataDelegate(string username, string password)
        : base("FetchAccount")
    {
        this.username = username;
        this.password = password;
    }

    public override void PrepareCommand(Command command)
    {
        command.Parameters.AddWithValue("Username", username);
        command.Parameters.AddWithValue("Password", password);
    }

    public override Account Translate(Command command, IDataRowReader reader)
    {
        if (!reader.Read())
            throw new RecordNotFoundException($"No account found for Username: {username}");

        return new Account(
            reader.GetInt32("AccountID"),
            reader.GetString("Username"),
            reader.GetString("Password"),
            reader.GetString("Email"),
            reader.GetString("FullName"),
            reader.GetDateTime("Birthday", DateTimeKind.Unspecified));
    }
}
