using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    class Employee: User, IEquatable<Employee>
    {
        private int workExperience = 0;
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

        public bool Equals(Employee other)
        {
            if (this.bithday == other.bithday && this.firstName == other.firstName && this.lastName == other.lastName && this.patronymic == other.patronymic)
            {
                return true;
            }
            else return false;
        }
    }
}
