namespace AbstractClassDesignDemo.Console
{
    // Have both abstract and concrete methods in abstract class
    internal class Program
    {
        // Abstract method - Concept of abstraction
        // - Abstract method (no implementation)
        // - Concrete method (with implementation)
        // - Abstract class can have both abstract and concrete methods
        // - Abstract class cannot be instantiated directly
        // - Abstract class can have constructors, fields, properties, and events

        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    // Example
    abstract class Person
    {
        private string _role;

        // Concrete method
        public void SetRole(string role)
        {
            _role = role;
        }

        // Abstract method
        protected abstract void SetOccupation(string occupation);
    }

    class Employee : Person
    {
        protected override void SetOccupation(string occupation)
        {
            System.Console.WriteLine($"Occupation: {occupation}");
        }
    }
}
