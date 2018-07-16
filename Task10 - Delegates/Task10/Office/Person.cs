using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Person
    {
        private string name;

        public event EventHandler<MyEventArgs> Came;
        public event EventHandler Left;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void Greet(string anotherPerson, int time)
        {
            if (time < 12)
            {
                Console.WriteLine("Good morning, {0}!, {1} said", anotherPerson, Name);
            }
            else if (time > 12 && time < 17)
            {
                Console.WriteLine("Good afternoon, {0}!, {1} said", anotherPerson, Name);
            }
            else if (time > 17)
            {
                Console.WriteLine("Good evening, {0}!, {1} said", anotherPerson, Name);
            }
        }

        public void TellGoodbye(string anotherPerson)
        {
            Console.WriteLine("Goodbye, {0}!, {1} said", anotherPerson, Name);
        }

        public void OnCame(int time)
        {
            MyEventArgs args = new MyEventArgs();
            args.time = time;
            if (Came != null)
            {
                Came(this, args);
            }
        }

        public void OnLeft()
        {
            if (Left != null)
            {
                Left(this, EventArgs.Empty);
            }
        }


    }
}
