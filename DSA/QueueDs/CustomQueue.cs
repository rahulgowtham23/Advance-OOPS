using System;
using System.Collections.Generic;
using System.Collections;

namespace QueueDs
{
    public class CustomQueue<Type> : IEnumerable,IEnumerator  // Created a generic class
    {
        // Non static field
        private int _head;
        private int _tail;
        private int _capacity;
        private int _count;

        //Properties
        public int Count { get{return _count;}}  


        // Array  to store the elements
        private Type[] _array;


        // Default constructor
        public CustomQueue()
        {
            _head = 0;
            _tail = 0;
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }

        // Parameterized constructor
        public CustomQueue(int size)
        {
            _head = 0;
            _tail = 0;
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }



        // Enqueue method
        public void Enqueue(Type value)
        {
            if(_tail==_capacity)
            {
                GrowSize();
            }
            _array[_tail] = value;
            _tail++;
            _count++;
        }

        // GrowSize method
        void GrowSize()      // It need not to be public
        {
            _capacity*=2;   // increase the capacity

            Type [] temp = new Type[_capacity]; // create temp array to store elements with the capacity size

            for(int i=_head; i<_tail; i++)
            {
                temp[i] = _array[i];    // store the array elements in temp array
            }
            _array = temp;      // replace the temp arrray to original array
        }


        // Peek Method
        public Type Peek()  // It should return value so return type is given
        {
            if(_head == _tail) // Queue is in empty state nothing to show
            {
                return default(Type);   // return default value of type
            }  
            else 
            {
                return _array[_head];   // It shows the first element 
            }
        }




        // Deueue method
        public Type Dequeue()
        {
            if(_head==_tail)    // queue is in empty state
            {
                return default(Type);
            }
            else
            {
                _head++;
                _count--;
                return _array[_head - 1];

            }
        }


        //Get Enumerator method return type is IEnumerator
        int position;
        public  IEnumerator GetEnumerator()
        {
            position = _head - 1;
            return (IEnumerator)this; 
        }
 

        public bool MoveNext()
        {
            if(position < _tail-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }


        public void Reset()
        {
            position = _head - 1;            
        }



        public object Current{get{return _array[position];}}
    }
}