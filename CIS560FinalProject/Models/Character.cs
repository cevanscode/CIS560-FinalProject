using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    /// <summary>
    /// Represents the choices a user has made to create their character
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The character's name
        /// </summary>
        public string? CharacterName { get; set; }

        /// <summary>
        /// The character's age
        /// </summary>
        public int CharacterAge { get; set; }

        /// <summary>
        /// The character's health
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// The amount of XP the character has accumulated
        /// </summary>
        public int XP { get; set; }

        /// <summary>
        /// The amount of copper the character has
        /// </summary>
        public int Copper {  get; set; }

        /// <summary>
        /// The character's class
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// The character's subclass
        /// </summary>
        public string SubclassName { get; set; } //wizard moment

        /// <summary>
        /// The talents the character has
        /// </summary>
        public List<Talent> CharacterTalents { get; set; }

        public Character(string characterName, int characterAge, int health, int xp, int copper, string className, string subclassName, List<Talent> talents)
        {
            CharacterName = characterName;
            CharacterAge = characterAge;
            Health = health;
            XP = xp;
            Copper = copper;
            ClassName = className;
            SubclassName = subclassName;
            CharacterTalents = talents;
        }
    }
}
