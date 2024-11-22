using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560FinalProject
{
    public class Talent
    {
        /// <summary>
        /// The talent's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The talent's description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The talent's rank
        /// </summary>
        public Rank Rank
        {
            get;
            set; 
        }

        /// <summary>
        /// The type of talent
        /// </summary>
        public TalentType Type { get; set; }

        public Talent(string name, string description, Rank rank, TalentType type)
        {
            Name = name;
            Description = description;
            Rank = rank;
            Type = type;
        }
    }
}
