using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Square : Icalculate
    {
        private int _number;

        //property
        public int Number { get{return _number;} set{_number = value;} }

        //method
        public int Calculate()
        {
            _number*=_number;
            return _number;
        }

    }
}