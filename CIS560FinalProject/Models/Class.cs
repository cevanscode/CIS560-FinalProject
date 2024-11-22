using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject.Models
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
        public string? ClassName { get; set; }

        /// <summary>
        /// The class's description
        /// </summary>
        public string? ClassDescription { get; set; }
    }
}
