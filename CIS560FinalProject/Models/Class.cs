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
        /// The class's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The class's description
        /// </summary>
        public string Description { get; set; }

        public Class(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
