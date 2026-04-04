namespace DefaultValuesDemo.Console
{
    internal class Program
    {
        public void ProcessRule(int value2)
        {
            int value1 = 0; // default value

            if (value2 > 5)
            {
                value1 = 6;
            }
            else
            {
                value1 = 10;
            }

            System.Console.Write(value1);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            Program program = new Program();
            program.ProcessRule(3); // Output: 10

            program.ProcessRule(6); // Output: 6
        }
    }
}
