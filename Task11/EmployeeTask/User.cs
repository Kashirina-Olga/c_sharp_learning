using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTask
{
    class User
    {
        protected string firstName;
        protected string lastName;
        protected string patronymic;
        protected string bithday;
        protected string age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }

        public string Bithday
        {
            get
            {
                return bithday;
            }
            set
            {
                bithday = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public virtual void PrintInfo()
        {
            //Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("ФИО: {0} {1} {2}", lastName, firstName, patronymic);
            Console.WriteLine("Дата рождения: {0}", bithday);
            Console.WriteLine("Возраст: {0}", age);
        }
    }
}
