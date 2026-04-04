namespace PropertiesConstructorDemo.Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; }  // This property only get

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Age = DateTime.Now.Year - birthDate.Year;
        }
    }
}
