using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = GenerateList(15); // personList указывает на первого человека в списке

            PrintList(personList);

            var p = personList;
            while (p != p.NextPerson) // пока человек не остался один в списке
            {
                #region Этот кусок для корректного вывода списка на экран. Если вывод не нужен, можно убрать
                if (personList == p.NextPerson)
                {
                    personList = p.NextPerson.NextPerson;
                }
                #endregion

                // <ВсяСоль>
                p = p.NextPerson = p.NextPerson.NextPerson;
                // </ВсяСоль>

                // Если убрать верхний регион, то может возникнуть ситуация, когда personList указывает на 
                // человека, который был удалён из списка. Возникнет бесконечный цикл.
                PrintList(personList);
                Console.ReadKey();
            }
        }

        // Генерация списка
        private static Person GenerateList(int n)
        {
            // Начинаем с последнего человека
            var currentPerson = new Person(n);
            var lastPerson = currentPerson;

            // затем создаём N-1 человек, указывая его порядковый номер и следующего за ним человека
            for (int i = n - 1; i > 0; i--)
            {
                currentPerson = new Person(i) { NextPerson = currentPerson };
            }

            // последнего человека закольцовываем с первым
            lastPerson.NextPerson = currentPerson;
            return currentPerson;
        }

        // Вывод списка на консоль
        private static void PrintList(Person personList)
        {
            var p = personList;
            do
            {
                System.Console.Out.Write(p.SequenceNumber);
                System.Console.Out.Write(" ");
                p = p.NextPerson;
            } while (p != personList);
            System.Console.Out.WriteLine();
        }
    }
}
