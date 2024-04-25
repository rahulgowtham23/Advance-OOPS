using System;
using System.Collections;



namespace DictionaryDs
{
    public class CustomDictionary<Tkey, Tvalue>: IEnumerable, IEnumerator  // Generic class with two data types key and value
    {
        // Non static fields
        private int _count;
        private int _capacity;

        // Properties
        public int Count { get{return _count;}}


        // Arrary to store key values convert to class and create an object for class and store the object in array with specified index
        //Private int [] _array;
        private KeyValue<Tkey, Tvalue> [] _array;


        public Tvalue this[Tkey key]        // Indexer
        {
            get
            {
                Tvalue value = default(Tvalue);
                LinearSearch(key, out value);
                return value;
            }
            set
            {
                int position = LinearSearch(key, out Tvalue value2);
                if(position>-1)
                {
                    _array[position].Value = value;
                }
            }
        }



        // Default constructor
        public CustomDictionary()
        {
            _count = 0;
            _capacity = 4;
            _array = new KeyValue<Tkey, Tvalue>[_capacity];
        }


        // Parameterized Constructor
        public CustomDictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValue<Tkey, Tvalue>[_capacity];
        }
        

        // Add method
        public void Add(Tkey key, Tvalue value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }

            int position = LinearSearch(key,out Tvalue value2);         // To avoid duplicate keys
            if(position==-1)
            {
                KeyValue<Tkey, Tvalue> data = new KeyValue<Tkey, Tvalue>();     // object created for the class KeyValue
                data.Key = key;   data.Value = value;
                
                _array[_count] = data;  //  store the object at particular index;
                _count++;
            }

        }



        // GrowSize method          
        void GrowSize()
        {
            _capacity*=2;   // Increase the capacity

            KeyValue<Tkey, Tvalue> [] temp = new KeyValue<Tkey, Tvalue>[_capacity];     // Temp array to store the values already present

            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];
            }

            _array = temp;
        }



        int LinearSearch(Tkey key, out Tvalue value)
        {
            int position = -1;

            value = default(Tvalue);

            for(int i=0;i<_count;i++)
            {   
                if(key.Equals(_array[i].Key))
                {
                    position = i;
                    value = _array[i].Value;
                    break;
                }
            }
            return position;
        }




        //IEnumerable
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return(IEnumerator)this;
        }



        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }   


        public void Reset()
        {
            position = -1;
        }


        public object Current{get{return _array[position];}}


    }
}