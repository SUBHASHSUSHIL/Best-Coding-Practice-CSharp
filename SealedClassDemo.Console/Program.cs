namespace SealedClassDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    // Do not add protected members in sealed class

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    sealed class Employee : Person
    {
        //protected string EmployeeCode { get; set; }
        private string EmployeeCode { get; set; }
    }

    class Accountant : Employee
    {
    }
}
