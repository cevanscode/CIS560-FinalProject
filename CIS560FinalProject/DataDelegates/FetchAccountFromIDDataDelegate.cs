using CIS560FinalProject;
using DataAccess;

internal class FetchAccountFromIDDataDelegate : DataReaderDelegate<Account>
{
    private readonly int _id;

    public FetchAccountFromIDDataDelegate(int ID)
        : base("FetchAccountFromID")
    {
        this._id = ID;
    }

    public override void PrepareCommand(Command command)
    {
        command.Parameters.AddWithValue("ID", _id);
    }

    public override Account Translate(Command command, IDataRowReader reader)
    {
        if (!reader.Read())
            throw new RecordNotFoundException($"No account found for ID: {_id}");

        return new Account(
            _id,
            reader.GetString("Username"),
            reader.GetString("AccountPassword"),
            reader.GetString("Email"),
            reader.GetString("FullName"),
            reader.GetDateTime("Birthday", DateTimeKind.Unspecified));
    }
}
