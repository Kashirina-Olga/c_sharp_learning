using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingTask
{
    class MyString
    {
        private char[] charArray;

        public MyString()
        {

        }

        public MyString(string myStr)
        {
            char [] myStrArray = myStr.ToCharArray();
            charArray = myStrArray;
        }

        public string ArrStr
        {
           get
            {
                return charArray.ToString();
            }
             
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            MyString newCharArray = new MyString();
            newCharArray.charArray = new char[str1.charArray.Length + str2.charArray.Length];


            for (int i = 0; i < str1.charArray.Length; i++)
            {
                newCharArray.charArray[i] = str1.charArray[i];
            }
            for (int j = 0; j < str2.charArray.Length; j++)
            {
                newCharArray.charArray[j + str1.charArray.Length] = str2.charArray[j];
            }

            return newCharArray;
        }

   

        public override string ToString()
        {
            string text = new string(charArray);
            return text;
        }
    }
}
