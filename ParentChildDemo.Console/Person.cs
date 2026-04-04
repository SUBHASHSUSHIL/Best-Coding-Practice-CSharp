using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildDemo.Console
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public string GetFullName()
        //{
        //    return string.Format("{0} {1}", FirstName, LastName);
        //}

        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
