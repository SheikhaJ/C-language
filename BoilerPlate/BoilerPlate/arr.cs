using System;

namespace BoilerPlate
{
    //using generics: reusable cose that can work with different type
    internal class Arr<T> //class Arr declare with type parameter T
    {
        private T[] _items; // Declaration

        public void Add(T item) //adding an item to the array
        {
            if (_items is null) //if it is null it well create a new array with single element
            {
                _items = new T[] { item };
            }
            else //otherwise it create a new array with length greater than the current array
            {
                int length = _items.Length;
                T[] temp = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = _items[i]; //copy the existing item and add a new item to the end
                }
                temp[temp.Length - 1] = item;
                _items = temp;
            }
        }

        public void RemoveAt(int index) //method to remove specific index from array 
        {
            if (index < 0 || index > _items.Length - 1) //if index invalid, method return without performing any action 
            {
                return;
            }
            int pos = 0;
            T[] temp = new T[_items.Length - 1]; //otherwise it will create array with length less than the current array
            for (int i = 0; i < _items.Length; i++)
            {
                if (i == index) //skipe the item of specific index
                {
                    continue;
                }
                temp[pos++] = _items[i]; //copy the remainig item
            }
            _items = temp;
        }

        public bool IsEmpty() => _items is null || _items.Length == 0; //method check if array is null or has length of 0

        public int Count() => _items.Length; //method return the number of items in array

        public void Display() //method print elements of array
        {
            for (int i = 0; i < _items.Length; ++i)
            {
                Console.WriteLine($"[{_items[i]}]");
            }
        }
    }
}
