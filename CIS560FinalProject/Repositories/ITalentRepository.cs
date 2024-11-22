
namespace CIS560FinalProject
{
    public interface ITalentRepository
    {
        /// <summary>
        /// Get all the talents from the database
        /// </summary>
        /// <returns>A list of all talent</returns>
        IReadOnlyList<Talent> GetAllTalents();

        /// <summary>
        /// Fetch one talent from the database
        /// </summary>
        /// <param name="id">The id of the talent to grab</param>
        /// <returns>A talent</returns>
        Talent FetchTalent(int id);

        /// <summary>
        /// Create a new talent in the repository 
        /// </summary>
        /// <param name="name">The talent's name</param>
        /// <param name="description">The talent's description</param>
        /// <param name="rank">The talent's rank</param>
        /// <param name="type">The talent's type</param>
        /// <returns>The created talent</returns>
        Talent CreateTalent(string name, string description, Rank rank, TalentType type);
    }
}
