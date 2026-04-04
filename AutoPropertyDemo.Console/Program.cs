namespace AutoPropertyDemo.Console
{
    // Properties with no logic should be auto-implemented
    internal class Program
    {
        // Bad Example
        // Unnecessary code
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Best Practice (Auto property)
        //public string Name { get; set; }


        // When to use full properties:
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception();
                _name = value;
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
