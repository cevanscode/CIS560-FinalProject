using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class Subclass
    {
        /// <summary>
        /// The subclass's identifer
        /// </summary>
        public int SubclassID { get; set; }

        /// <summary>
        /// The class's ID that the subclass is associated with
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// The Subclass's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of Subclass
        /// </summary>
        public string Description { get; set; }

        public Subclass(int subclassID, int classID, string name, string description)
        {
            SubclassID = subclassID;
            ClassID = classID;
            Name = name;
            Description = description;
        }
    }
}
