
namespace CIS560FinalProject
{
    public interface ISubclassRepository
    {
        /// <summary>
        /// Get all the subclasses from the database
        /// </summary>
        /// <returns>A list of all subclasses</returns>
        IReadOnlyList<Subclass> RetrieveSubclasses();

        /// <summary>
        /// Fetch one subclass from the database
        /// </summary>
        /// <param name="subclassID">The id of the subclass to grab</param>
        /// <returns>A subclass</returns>
        Subclass GetSubclass(string name);

        /// <summary>
        /// Create a new subclass in the repository 
        /// </summary>
        /// <param name="name">The subclass's name</param>
        /// <param name="description">The sybclass's description</param>
        /// <returns>The created class</returns>
        public Subclass UpdateSubclass(int classID, string name, string description);
    }
}
