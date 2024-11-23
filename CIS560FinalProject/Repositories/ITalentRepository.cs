﻿
namespace CIS560FinalProject
{
    public interface ITalentRepository
    {
        /// <summary>
        /// Get all the talents from the database
        /// </summary>
        /// <returns>A list of all talent</returns>
        public IReadOnlyList<Talent> RetrieveTalents();

        /// <summary>
        /// Get all talents for the given class
        /// </summary>
        /// <param name="className">The name of the class</param>
        /// <returns>A list of talents for className</returns>
        public IReadOnlyList<Talent> RetrieveTalentsForClass(string className);

        /// <summary>
        /// Get all talents for the given class
        /// </summary>
        /// <param name="subclassName">The name of the class</param>
        /// <returns>A list of talents for subclassName</returns>
        public IReadOnlyList<Talent> RetrieveTalentsForSubclass(string subclassName);

        /// <summary>
        /// Fetch one talent from the database
        /// </summary>
        /// <param name="id">The id of the talent to grab</param>
        /// <returns>A talent</returns>
        public Talent GetTalent(string name);

        /// <summary>
        /// Create a new talent in the repository 
        /// </summary>
        /// <param name="name">The talent's name</param>
        /// <param name="description">The talent's description</param>
        /// <param name="rank">The talent's rank</param>
        /// <param name="type">The talent's type</param>
        /// <returns>The created talent</returns>
        public Talent UpdateTalent(string name, string description, Rank rank, TalentType type);
    }
}
