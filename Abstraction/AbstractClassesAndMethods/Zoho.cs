using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public class Zoho:Employee
    {
        //Abstract property definition
        public override string Name{get{return _name;}set{_name=value;}}



        //Abstract method definition
        public override double Salary(int dates)
        {
            Amount = (double)dates*1000;
            return Amount;
        }
    }
}