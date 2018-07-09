using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Employee: User
    {
        private int workExperience=0;
        private string position;
        
        public int WorkExperience
        {
            get
            {
                return workExperience;
            }

            set
            {
                workExperience = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        override
        public void PrintInfo()
        {
            //Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("ФИО: {0} {1} {2}", lastName, firstName, patronymic);
            Console.WriteLine("Дата рождения: {0}", bithday);
            Console.WriteLine("Возраст: {0}", age);
            Console.WriteLine("Должность: {0}", position);
            Console.WriteLine("Стаж: {0}", workExperience);

        }
    }
}
