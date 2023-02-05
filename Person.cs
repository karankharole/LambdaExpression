using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person(string ssn, string name, string adress, int age)
        {
            SSN = ssn;
            Name = name;
            Address = adress;
            Age = age;
        }

    }
}
