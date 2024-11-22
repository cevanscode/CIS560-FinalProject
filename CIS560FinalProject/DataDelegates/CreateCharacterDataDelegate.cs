using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    internal class CreateCharacterDataDelegate : NonQueryDataDelegate<Character>
    {
        private readonly int accountID;
        public readonly string name;
        public readonly int age;
        public readonly int health;
        public readonly int xp;
        public readonly int copper;
        public readonly string className;
        public readonly string subclassName;
        public readonly List<Talent> talents;

        public CreateCharacterDataDelegate(int accountID, string name, int age, int health, int xp, int copper, string characterClass, string subclass, List<Talent> talents)
            : base("CreateCharacter")
        {
            this.accountID = accountID;
            this.name = name;
            this.age = age;
            this.health = health;
            this.xp = xp;
            this.copper = copper;
            this.className = characterClass;
            this.subclassName = subclass;
            this.talents = talents;
        }

        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);

            // How to handle Foreign Key Shit with the Columns?
            // IE, how to Character, Class, Subclass, Talent, and Account Communicate on this side?
            command.Parameters.AddWithValue("AccountID", accountID);
            command.Parameters.AddWithValue("CharacterName", name);
            command.Parameters.AddWithValue("CharacterAge", age);
            command.Parameters.AddWithValue("Health", health);
            command.Parameters.AddWithValue("XP", xp);
            command.Parameters.AddWithValue("Copper", copper);

            var p = command.Parameters.Add("CharacterID", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Character Translate(Command command)
        {
            return new Character(name, age, health, xp, copper, className, subclassName, talents);
        }
    }
}
