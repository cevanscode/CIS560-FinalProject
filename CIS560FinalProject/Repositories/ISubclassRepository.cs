
namespace CIS560FinalProject
{
    public interface ISubclassRepository
    {
        /// <summary>
        /// Get all the subclasses from the database
        /// </summary>
        /// <param name="className">The className that each class belongs to</param>
        /// <returns>A list of all subclasses</returns>
        IReadOnlyList<Subclass> RetrieveSubclasses(string className);

        /// <summary>
        /// Fetch one subclass from the database
        /// </summary>
        /// <param name="name">The name of the subclass to grab</param>
        /// <param name="className">The associated className for this class</param>
        /// <returns>A subclass</returns>
        Subclass GetSubclass(string name);

        /// <summary>
        /// Create a new subclass in the repository 
        /// </summary>
        /// <param name="name">The subclass's name</param>
        /// <param name="description">The sybclass's description</param>
        /// <returns>The created class</returns>
        public Subclass UpdateSubclass(string name, string description, string className);
    }
}
