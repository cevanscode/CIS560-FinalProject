using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject.Models
{
    public class Subclass
    {
        /// <summary>
        /// The Subclass's name
        /// </summary>
        public string? SubclassName { get; set; }

        /// <summary>
        /// The subclass's identifer
        /// </summary>
        public int SubclassID { get; set; }

        /// <summary>
        /// The class's ID that the subclass is associated with
        /// </summary>
        public int ClassID { get; set; }
    }
}
