namespace CleanInitializationDemo.Console
{
    internal class Program
    {
        // Remove member initialization if they are being set before being used
        public int GetValue()
        {
            int n1 = int.MinValue;
            int n2 = int.MinValue;

            n1 = GetNumber1();
            n2 = GetNumber1();

            return n1 + n2;
        }

        private int GetNumber1()
        {
            return 5;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
