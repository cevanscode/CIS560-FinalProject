using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class Class
    {
        /// <summary>
        /// The class's identifer
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// The class's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The class's description
        /// </summary>
        public string Description { get; set; }

        public Class(int classID, string name, string description)
        {
            ClassID = classID;
            Name = name;
            Description = description;
        }
    }
}
