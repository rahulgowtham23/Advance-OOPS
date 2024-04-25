using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDs
{
    public partial class CustomList <Type>  //<Type> used to specify the data type of list at the time of object creation
    {
        // Create two non static field 1.count 2.capacity of int type
        private int _count;
        private int _capacity;

        // Create a property for both field
        public int Count{get{return _count;}}   // read only property
        public int Capacity{get{return _capacity;}} // read only property


        private Type [] _array; // Created an Array for data contain



        public Type this[int index]         // Indexers
        {
            get{return _array[index] ;}
            set{_array[index] = value ;}
        }


        //List default constructor
        public CustomList()
        {
            _count=0;   // Initialize count
            _capacity=4;  //Initialize capacity 
            _array = new Type [_capacity]; // Array initialization  array size will be 4 at the time of object creation
        }


        //List parameterized constructor
        public CustomList(int size)
        {
            _count = 0; //At initial the count will be 0
            _capacity = size; // capacity will be user defined size
            _array = new Type [_capacity];
        }





        // Methods Add - method
        public void Add(Type element)   // we need to pass the type of list as an parameter to the method
        {
            //add functionality
            if(_count==_capacity)
            {
                GrowSize();
            }

            _array[_count] = element; // At index 1st element will be added
            _count++;                //  count will be incremented when next element added
        }



        //Method to grow the array size
        void GrowSize()
        {
            _capacity = _capacity * 2;          // increase the capacity
            Type [] temp = new Type[_capacity]; // create a temp array for new capacity size

            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];    // store the array elements in temp array
            }

            _array = temp;  // replace temp array with _array  so _array has capacity of temp array      _array capacity will be 8 but 4 elements are stored at initial 
        }



        // Add range Method
        public void AddRange(CustomList<Type> elements) 
        {
             _capacity = _count + elements.Count + 4;

             Type [] temp = new Type[_capacity]; 

            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];
            }

            int k=0;
            for(int i=_count; i<_count + elements.Count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            
            _array = temp;
            _count = _count + elements.Count;
        }



        // Contains Method
        public bool Contains(Type element)
        {   
            bool temp = false;

            foreach(Type data in _array)
            {
                if(data.Equals(element))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }


        //IndexOf Method
        public int IndexOf(Type element)
        {
            int index = -1;

            for(int i=0; i<_count; i++)
            {
                if(element.Equals(_array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        //Insert Method
        //2 =>100
        // 10,20,30,40,50,60,70
        // 10,20,100,30,40,50,60,70
        public void Insert(int position, Type element)
        {
            _capacity = _capacity + 1 + 4; //first increase the capacity because when we add one element the size will be increased

            Type [] temp = new Type[_capacity];

            for(int i=0; i<_count+1; i++)
            {
                if(i<position)
                {
                    temp[i] = _array[i];
                }
                else if(i==position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i-1];
                }

            }
            _count++;
            _array = temp;
        }


        // Remove Method
        // 10,20,30,40,50,60,70
        // position = 2
        // 10,20,40,50,60,70
        public void RemoveAt(int position)
        {
            for(int i=0;i<_count-1;i++)
            {
                if(i>=position)
                {
                    _array[i] = _array[i+1];
                }
            }   
            _count--;
        }


        // Remove Method
        public bool Remove(Type element)
        {
            int position = IndexOf(element);

            if(position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }


        //Reverse Method
        // 1,2,3,4
        public void Reverse()
        {
            Type [] temp = new Type[_capacity];
            int j=0;
            for(int i=_count-1; i>=0; i--)
            {
                temp[j] = _array[i]; 
                j++;
            }
            _array = temp;
        }


        //InsertRange method

        public void InsertRange(int position, CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;

            Type [] temp = new Type[_capacity];

            for(int i=0;i<position;i++)
            {
                temp[i] = _array[i];
            }
            
            int j=0;
            for(int i=position;i<position + elements.Count;i++)
            {
                temp[i] = elements[j];
                j++; 
            }
            int k=position;
            for(int i = position+elements.Count; i<Count + elements.Count;i++)
            {
                temp[i] = _array[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }


        // Sort method
        public void Sort()
        {
            for(int i=0;i<_count;i++)
            {
                for(int j=0;j<_count;j++)
                {
                    if(IsGreater(_array[j],_array[j+1]))
                    {
                        Type temp = _array[j+1];
                        _array[j+1] =  _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }

        public bool IsGreater(Type value, Type value1)
        {
            int result = Comparer<Type>.Default.Compare(value,value1);

            //value is greater = 1, value is less = -1, equal = 0

            if(result>0)
            {
                return true;
            }
            return false;
        }
        

    }
}