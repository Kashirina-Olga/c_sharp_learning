using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Program
    {
        delegate void Message(string name, int time);

        static void Main(string[] args)
        {
            Person hugo = new Person { Name = "Hugo" };

            hugo.Came += new EventHandler<MyEventArgs>(hugo_Came);

            hugo.OnCame(15);

            Person adam = new Person { Name = "Adam" };

            adam.Came += new EventHandler<MyEventArgs>(adam_Came);

            adam.OnCame(7);

            Console.ReadKey();
        }

        static void hugo_Came(object sender, MyEventArgs e)
        {
            Console.WriteLine("\nHugo has come");
            Person john = new Person { Name = "John" };
            Person mary = new Person { Name = "Mary" };
            Person bill = new Person { Name = "Bill" };

            Message greetByJohn = new Message(john.Greet);
            Message greetByMary = new Message(mary.Greet);
            Message greetByBill = new Message(bill.Greet);

            Message greetByUs = (Message)Delegate.Combine(greetByJohn, greetByMary, greetByBill);

            greetByUs("Hugo", e.time);
        }

        static void adam_Came(object sender, MyEventArgs e)
        {
            Console.WriteLine("\nAdam has come");
            Person john = new Person { Name = "John" };
            Person mary = new Person { Name = "Mary" };
            Person bill = new Person { Name = "Bill" };

            Message greetByJohn = new Message(john.Greet);
            Message greetByMary = new Message(mary.Greet);
            Message greetByBill = new Message(bill.Greet);

            Message greetByUs = (Message)Delegate.Combine(greetByJohn, greetByMary, greetByBill);

            greetByUs("Adam", e.time);
        }


        static void hugo_Left(object sender, EventArgs e)
        {
            Console.WriteLine("Hugo has left");
            Person john = new Person { Name = "John" };
            Person mary = new Person { Name = "Mary" };
            Person bill = new Person { Name = "Bill" };


        }
    }
}
