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
        /// The character's identifier
        /// </summary>
        public int CharacterID { get; set; }

        /// <summary>
        /// The associated identifier for the account that owns this character
        /// </summary>
        public int AccountID { get; set; }

        /// <summary>
        /// The character's name
        /// </summary>
        public string? CharacterName { get; set; }

        /// <summary>
        /// The character's age
        /// </summary>
        public uint CharacterAge { get; set; }

        /// <summary>
        /// The character's health
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// The amount of XP the character has accumulated
        /// </summary>
        public uint XP { get; set; }

        /// <summary>
        /// The amount of copper the character has
        /// </summary>
        public int Copper {  get; set; }

        /// <summary>
        /// The character's class
        /// </summary>
        public Class? CharacterClass { get; set; }

        /// <summary>
        /// The character's subclass
        /// </summary>
        public Subclass? CharacterSubclass { get; set; }

        /// <summary>
        /// The talents the character has
        /// </summary>
        public List<Talent>? CharacterTalents { get; set; }
    }
}
