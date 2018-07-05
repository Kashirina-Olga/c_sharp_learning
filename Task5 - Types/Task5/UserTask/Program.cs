using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.GetEncoding(866);

            User user = new User();
            Console.WriteLine("Введите фамилию");
            user.LastName = Console.ReadLine();

            Console.WriteLine("Введите имя");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Введите отчество");
            user.Patronymic = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            user.Bithday = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            user.Age = Console.ReadLine();

            user.PrintInfo();
            Console.ReadKey();
        }
    }
}
