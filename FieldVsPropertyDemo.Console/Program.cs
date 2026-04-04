namespace FieldVsPropertyDemo.Console
{
    // Never have public fields, use properties instead
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    // BAD design
    //class Person
    //{
    //    // Encapsulation break
    //    // No validation, no control over the data
    //    public string FirstName;
    //    public string LastName;
    //}

    // Avoid this (extra method)
    //public void SetFullName()
    //{
    //   FullName = FirstName + " " + LastName;
    //}

    // Better (Controlled access)
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
