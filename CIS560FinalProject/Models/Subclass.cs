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
        /// The Subclass's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of Subclass
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of the class this subclass belongs to
        /// </summary>
        public string ClassName { get; set; }

        public Subclass(string name, string description, string className)
        {
            Name = name;
            Description = description;
            ClassName = className;
        }
    }
}
