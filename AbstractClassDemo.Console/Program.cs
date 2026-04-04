namespace AbstractClassDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    abstract class Person
    {
        protected Person() { }
    }

    class Employee : Person
    {
    }
}
