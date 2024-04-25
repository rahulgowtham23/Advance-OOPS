using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First : Third
    {
        private int _privateNumber = 10;    // Private field

        public int PrivateOut { get{return _privateNumber;}}

        public int PublicNumber = 20;   // Public field

        protected int ProtectedNumber = 30;

        public int ProtectedInternalOut { get{return InternalProtected;}}
    }
}