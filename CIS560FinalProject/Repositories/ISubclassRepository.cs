using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject.Repositories
{
    public interface ISubclassRepository
    {
        /// <summary>
        /// Get all the subclasses from the database
        /// </summary>
        /// <returns>A list of all subclasses</returns>
        IReadOnlyList<Subclass> GetAllSubclasses();

        /// <summary>
        /// Fetch one subclass from the database
        /// </summary>
        /// <param name="id">The id of the subclass to grab</param>
        /// <returns>A subclass</returns>
        Subclass FetchSubclass(int id);

        /// <summary>
        /// Create a new subclass in the repository 
        /// </summary>
        /// <param name="name">The subclass's name</param>
        /// <param name="description">The sybclass's description</param>
        /// <returns>The created class</returns>
        Subclass CreateSubclass(string? name, string? description);
    }
}
