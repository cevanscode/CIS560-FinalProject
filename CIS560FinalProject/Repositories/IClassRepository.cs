
namespace CIS560FinalProject
{
    public interface IClassRepository
    {
        /// <summary>
        /// Get all the classes from the database
        /// </summary>
        /// <returns>A list of all classes</returns>
        IReadOnlyList<Class> GetAllClasses();

        /// <summary>
        /// Fetch one class from the database
        /// </summary>
        /// <param name="id">The id of the class to grab</param>
        /// <returns>A class</returns>
        Class FetchClass(int id);

        /// <summary>
        /// Create a new class in the repository 
        /// </summary>
        /// <param name="name">The class's name</param>
        /// <param name="description">The class's description</param>
        /// <returns>The created class</returns>
        Class CreateClass(string name, string description);
    }
}
