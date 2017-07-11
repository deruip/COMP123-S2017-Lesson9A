using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Date: July 11, 2017
 * Description: This is the abstract class Human which other subclasses will derive from
 * Version: 0.1 - Class created
*/
namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the Human Abstract class
    /// </summary>
    public abstract class Human
    {
        // Private Fields (Instance Variables)
        private string _name;

        // Public Properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        // Constructors
        /// <summary>
        /// This is the constructor for the Human abstract class.
        /// It requires one parameter - name (string).
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
    }
}