using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayTask
{
    class DynamicArray
    {
        //private T[] array;

        public static T[] InitializeArray<T>(int length) where T :  new()
        {

            T[] array = new T[length];

            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }


        public static T[] InitializeArray<T>() where T : new()
        {

            T[] array = new T[8];

            for (int i = 0; i < 8; ++i)
            {
                array[i] = new T();
            }

            return array;
        }

        public static T[] InitializeArray<T>(T[] newArray) where T : new()
        {
            T[] array = newArray;     
            return array;
        }


        public static T[] Insert<T> (T[] arr, int index, T element) where T: IComparable<T>
        {
            T[] result = new T[arr.Length + 1];

            try
            {
                Array.Copy(arr, result, index);
                result[index] = element;
                Array.Copy(arr, index, result, index + 1, arr.Length - index);
            }
            catch (Exception)
            {
                new ArgumentOutOfRangeException();
            }

            //return result[index].CompareTo(element) > 0;
            return result;
        }

        //private void Add<T> (T[] arr, T element)
        //{
        //    if (arr[arr.Length] != null)
        //    {
        //        T[] result = new T[arr.Length + 1];
        //    }

        //    Array.Copy(arr, result, index);
        //    result[index] = element;
        //    Array.Copy(arr, index, result, index + 1, arr.Length - index);
        //}

        //public T this[int index]
        //{
        //    get
        //    {
        //        return array[index];
        //    }
        //}

        //public T this[]
        //{
        //    get
        //    {
        //        return array[8];
        //    }
        //}
    }
}
