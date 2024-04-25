using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomStack
{
    public class Stack<Type>    // Generic class define the type
    {
        // Non static field
        private int _capacity;
        private int _top;



        // Proerties
        public int Capacity { get{return _capacity;} } // Readonly property
        public int Count { get{return _top + 1;}}  // _top = -1  Count = 0,  _top = 0 Count = 1,  _top = 1 Count = 2,.....


        // Array
        private Type[] _array;  // Initialize array to store the data



        // Default Constructor
        public Stack()
        {
            _top = -1;
            _capacity = 4;
            _array = new Type[_capacity];
        }


        // Parameterized constructor
        public Stack(int size)
        {
            _top = -1;
            _capacity = size;
            _array = new Type[_capacity];
        }


        // Push method
        public void Push(Type value)
        {
            if(_top+1==_capacity)
            {
                GrowSize();
            }
            _array[_top+1] = value;
            _top++;
        }

        // GrowSize method
        void GrowSize()
        {
            _capacity*=2;   //increase the capacity

            Type [] temp = new Type[_capacity]; // temp array with size of increased

            for(int i=0;i<_top+1;i++)
            {
                temp[i] = _array[i];    // store array elements in temp array
            } 

            _array = temp;  // replace temp array with array
        }


        // Peek method
        public Type Peek()
        {
            if(_top==-1)
            {
                return default(Type);   // if it is a empty stack
            }
            else
            {
                return _array[_top];
            }
        }


        // Pop method
        public Type Pop()
        {
            if(_top==-1)
            {
                return default(Type);
            }
            else
            {
                 _top--;                            
                return _array[_top+1];
            }
        }


        // Contains method
        public bool Contains(Type value)
        {
            bool flag = false;

            foreach(Type element in _array)
            {
                if(value.Equals(element))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }




    }
}