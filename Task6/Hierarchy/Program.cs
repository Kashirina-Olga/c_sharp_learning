using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);

            Employee employee = new Employee();
            Console.WriteLine("Введите фамилию");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Введите имя");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Введите отчество");
            employee.Patronymic = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            employee.Bithday = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            employee.Age = Console.ReadLine();

            Console.WriteLine("Введите должность");
            employee.Position = Console.ReadLine();

            Console.WriteLine("Введите стаж");
            employee.WorkExperience = Convert.ToInt32(Console.ReadLine(), 16);

            employee.PrintInfo();
            Console.ReadKey();
        }
    }
}
