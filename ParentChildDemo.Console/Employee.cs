using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildDemo.Console
{
    public class Employee : Person
    {
        public string Role { get; private set; }

        public Employee(string firstName, string lastName, string role)
            : base(firstName, lastName)
        {
            Role = role;
        }

        public override string GetFullName()
        {
            return string.Format("{0} {1} - {2}", FirstName, LastName, Role);
        }
    }
}
