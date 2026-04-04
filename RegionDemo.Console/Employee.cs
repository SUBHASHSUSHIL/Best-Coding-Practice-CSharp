using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionDemo.Console
{
    public class Employee
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        #endregion

        #region Constructor
        public Employee(string firstName, string lastName, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
        #endregion

        #region Public Methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        #endregion

        #region Private Methods
        private void Log()
        {
            // some logic
        }
        #endregion
    }
}
