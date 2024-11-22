namespace DataAccess
{
    public interface IDataDelegate
    {
        public string ProcedureName { get; }

        public void PrepareCommand(Command command);
    }
}