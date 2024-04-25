using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee  //abstract class
    {

        //Abstract class - partial abstraction.
        //It has property, method, constructor, destructor, indexers, events.
        //Can have both abstract declaration and normal definition.
        //Can only used with and inherited class.
        //Not support multiple inheritance.
        //It cannot be static class.

        protected string _name; //Normal fields

        public abstract string Name{get; set;} //Abstract property

        public double Amount { get; set; }  //normal property


        public string Display() //Normal Method
        {
            return _name;
        }

        public abstract double Salary(int dates); // abtract method - Only Declaration
    }
}