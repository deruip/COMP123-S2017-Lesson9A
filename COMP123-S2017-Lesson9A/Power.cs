using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 11, 2017
 * Description: This is the new Power data type
 * Version: 0.2 Add a custom constructor to assign Name and Rank
*/
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// The Power class contains the data and structure of each Super Power.
    /// </summary>
    public class Power
    {
        // Public Properties
        public string Name { get; set; }
        public int Rank { get; set; }

        // Constructors
        /// <summary>
        /// This is the power constructor
        /// Takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}