using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DynamicArray<T> where T : IComparable<T>, new()
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                yield return item;
            }
        }


        public DynamicArray(int length)
        {
            array = new T[length];

            for (int i = 0; i < length; ++i)
            {
                array[i] = default(T);
            }
        }

        public DynamicArray()
        {
            array = new T[8];

            for (int i = 0; i < 8; ++i)
            {
                array[i] = default(T);
            }
        }

        public DynamicArray(T[] newArray)
        {
            array = newArray;
        }

        public DynamicArray(List<T> list)
        {
            array = new T[list.Count];
            for (int i=0; i < array.Length; i++)
            {
                array[i] = list.ElementAt(i);
            }
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
