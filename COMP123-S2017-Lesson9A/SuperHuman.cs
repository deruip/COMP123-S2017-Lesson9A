using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 11, 2017
 * Description: This is the SuperHuman sub class
 * Version: 0.2 - Added Private Initialize Method
*/
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the SuperHuman sub class.
    /// It inherits from the Human SuperClass
    /// </summary>
    public class SuperHuman : Human
    {
        // Private Fields
        private List<Power> _powers;

        // Public Properties

        // Constructors
        public SuperHuman(string name)
            :base(name)
        {

        }

        // Private Methods
        /// <summary>
        /// This method intializes and assigns default values to class fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }

        // Public Methods
    }
}