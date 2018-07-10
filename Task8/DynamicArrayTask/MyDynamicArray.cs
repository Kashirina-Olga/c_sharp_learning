using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayTask
{
    class MyDynamicArray<T> where T: IComparable<T>, new()
    {
        private T[] array;
        private int pointer = 0;

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public int Pointer
        {
            get
            {
                return pointer;
            }
        }

        public MyDynamicArray (int length)
        {
            array = new T[length];

            for (int i = 0; i < length; ++i)
            {
                array[i] = default(T);
            }
        }

        public MyDynamicArray() 
        {
            array = new T[8];

            for (int i = 0; i < 8; ++i)
            {
                array[i] = default(T);
            }
        }

        public MyDynamicArray(T[] newArray)
        {
            array = newArray;
        }

        public bool Insert(int index, T element)
        {
            T[] result = new T[array.Length + 1];

            try
            {
                Array.Copy(array, result, index);
                result[index] = element;
                Array.Copy(array, index, result, index + 1, array.Length - index);
                array = result;
            }
            catch (Exception)
            {
                new ArgumentOutOfRangeException();
            }

            return result[index].CompareTo(element) > 0;
        }

        public void Add(T item)
        {
            if (pointer == array.Length - 1)
                Resize(array.Length * 2);        
            array[pointer++] = item;
        }

        public void AddRange(T[] arrayToAdd)
        {
            if (pointer + arrayToAdd.Length >= array.Length - 1)
                Resize(array.Length * 2);
            try
            {
                for (int i = 0; i < arrayToAdd.Length; i++)
                {
                    array[pointer + i] = arrayToAdd[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                Resize(array.Length * 2);
            }
           
            pointer += arrayToAdd.Length;
        }

        private void Resize(int newLength)
        {
            T[] newArray = new T[newLength];
            Array.Copy(array, 0, newArray, 0, pointer);
            array = newArray;
        }

        public void Remove(int index)
        {
            for (int i = index; i < pointer; i++)
                array[i] = array[i + 1];
            array[pointer] = default(T);
            pointer--;
        }

        public T Get(int index)
        {
            T result = default(T);
            try
            {
                result = (T)array[index];
            }
            catch (Exception)
            {
                new ArgumentOutOfRangeException();
            }
            
            return result;
        }

    }
}
