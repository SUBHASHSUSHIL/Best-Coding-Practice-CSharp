namespace PropertyVsMethodDemo.Console
{
    // Avoid using write-only properties, use a method instead
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    // Bad Example
    //class Person
    //{
    //    private string _name;

    //    public string Name
    //    {
    //        set { _name = value; } // ❌ write-only
    //    }
    //}

    // When to use Property
    // - When you want to expose a value that can be read and/or written
    // - When you want to provide a simple way to access data without additional logic
    // public string Name { get; set; }

    // Avoid property when:
    // Only set is needed, or when setting a value requires validation or additional logic
    // Heavy logic in property setters can lead to unexpected side effects and make the code harder to maintain and debug.

    // Set method use case:
    // Method use karo (SetName)  not property
    // Write-only property mat banao

    // Better Approach (Use Method)
    class PersonWithMethod
    {
        private string _name;
        public void SetName(string name)
        {
            _name = name; // ✅ clear intent
        }
    }

    // Better (Best Practice)
    class Person
    {
        private string _name;

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            _name = name;
        }
    }
}
