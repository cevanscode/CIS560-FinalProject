using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject.Models
{
    public class Talent
    {
        /// <summary>
        /// The identifier for the talent
        /// </summary>
        public int TalentID { get; set; }

        /// <summary>
        /// The talent's name
        /// </summary>
        public string? TalentName { get; set; }

        /// <summary>
        /// The talent's description
        /// </summary>
        public string? TalentDescription { get; set; }

        /// <summary>
        /// The talent's rank
        /// </summary>
        public int TalentRank
        {
            get;
            set; //restrict to 1, 2, 3
        }

        /// <summary>
        /// The type of talent
        /// </summary>
        public string? TalentType { get; set; } //this is not a string, fix later
    }
}
