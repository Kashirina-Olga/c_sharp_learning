using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCircle
{
    class Person
    {
        public int SequenceNumber { get; private set; }

        public Person NextPerson { get; set; }

        public Person(int sequenceNumber)
        {
            SequenceNumber = sequenceNumber;
        }
    }
}
