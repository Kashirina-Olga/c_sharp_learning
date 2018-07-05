using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.GetEncoding(866);

            DateTime date = new DateTime(2008, 4, 10);
            double value = 12345.6789;


            Console.WriteLine("For data");
            // Console.WriteLine(date.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU")));
            //Console.WriteLine(date.ToString("d", CultureInfo.CreateSpecificCulture("en-EN")));
            Console.WriteLine("|'ru'  vs 'en'| {0} |", PrintDifferenceForData(date, CultureInfo.CreateSpecificCulture("ru-RU"), CultureInfo.CreateSpecificCulture("en-EN")));
            Console.WriteLine("----------------------");

            //Console.WriteLine(date.ToString("d", DateTimeFormatInfo.InvariantInfo));
            //Console.WriteLine(date.ToString("d", CultureInfo.CreateSpecificCulture("en-EN")));
            Console.WriteLine("|'en'  vs 'inv'| {0} |", PrintDifferenceForData(date, DateTimeFormatInfo.InvariantInfo, CultureInfo.CreateSpecificCulture("en-EN")));
            Console.WriteLine("----------------------");


            // Console.WriteLine(date.ToString("d", DateTimeFormatInfo.InvariantInfo));
            // Console.WriteLine(date.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("|'ru'  vs 'inv'| {0} |", PrintDifferenceForData(date, DateTimeFormatInfo.InvariantInfo, CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("----------------------");

            Console.WriteLine("\nFor numbers");
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("|'ru'  vs 'en'| {0} |", PrintDifferenceForNumber(value, CultureInfo.CreateSpecificCulture("en-US"), CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("----------------------");

            //Console.WriteLine(value.ToString("C", DateTimeFormatInfo.InvariantInfo));
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("|'en'  vs 'inv'| {0} |", PrintDifferenceForNumber(value, DateTimeFormatInfo.InvariantInfo, CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("----------------------");
            

            //Console.WriteLine(value.ToString("C", DateTimeFormatInfo.InvariantInfo));
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("|'ru'  vs 'inv'| {0} |", PrintDifferenceForNumber(value, DateTimeFormatInfo.InvariantInfo, CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.WriteLine("----------------------");
            
            Console.ReadKey();
        }

        static private string PrintDifferenceForData(DateTime date, IFormatProvider providerOne, IFormatProvider providerTwo)
        {
            string providerOneStr = date.ToString("d", providerOne);
            string providerTwoStr = date.ToString("d", providerTwo);

            char[] providerOneCharArray = providerOneStr.ToCharArray();
            char[] providerTwoCharArray = providerTwoStr.ToCharArray();

            string result = GetDifference(providerOneCharArray, providerTwoCharArray);

            return result;
        }

        static private string PrintDifferenceForNumber(double number, IFormatProvider providerOne, IFormatProvider providerTwo)
        {
            string providerOneStr = number.ToString("C", providerOne);
            string providerTwoStr = number.ToString("C", providerTwo);

            char[] providerOneCharArray = providerOneStr.ToCharArray();
            char[] providerTwoCharArray = providerTwoStr.ToCharArray();

            string result = GetDifference(providerOneCharArray, providerTwoCharArray);

            return result;
        }

        private static string GetDifference(char[] providerOneCharArray, char[] providerTwoCharArray)
        {
            List<char> list = new List<char>();

            for (int j = 0; j < providerOneCharArray.Length; j++)
            {
                if (!providerTwoCharArray.Contains(providerOneCharArray[j]))
                {
                    list.Add(providerOneCharArray[j]);
                }
            }

            for (int j = 0; j < providerTwoCharArray.Length; j++)
            {
                if (!providerOneCharArray.Contains(providerTwoCharArray[j]))
                {
                    list.Add(providerTwoCharArray[j]);
                }
            }

            string result = string.Join(null, list);
            return result;
        }
    }
}
