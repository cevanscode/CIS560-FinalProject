﻿
namespace CIS560FinalProject
{
    public interface ICharacterRepository
    {
        /// <summary>
        /// Retrieves all characters from the database
        /// </summary>
        /// <returns>List containing all characters</returns>
        IReadOnlyList<Character> RetrieveCharacters();

        /// <summary>
        /// Grabs a character from the database
        /// </summary>
        /// <param name="characterID">The id of the character to retrieve</param>
        /// <returns>A character</returns>
        Character FetchCharacter(int characterID);

        /// <summary>
        /// Creates a new character in the repository
        /// </summary>
        /// <param name="accountID">The associated account ID</param>
        /// <param name="name">The character's name</param>
        /// <param name="age">The character's age</param>
        /// <param name="health">The amount of health the character has</param>
        /// <param name="xp">The amount of xp the character has accumulated</param>
        /// <param name="copper">The amount of copper the character has collected</param>
        /// <param name="characterClass">The character's class</param>
        /// <param name="subclass">The character's subclass</param>
        /// <param name="talents">The talents the character has</param>
        /// <returns>A character that is created</returns>
        Character CreateCharacter(int accountID, string name, int age, int health, int xp, int copper, Class characterClass, Subclass subclass, List<Talent> talents);
    }
}
