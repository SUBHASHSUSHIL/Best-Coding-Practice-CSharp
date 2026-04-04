namespace CurlyBracesDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            int value = 10;

            // This is Bad Practice and should be avoided.
            // Always use curly braces to define the scope of your if statements, even if it's just one line of code.

            //if (value > 5)
            //    System.Console.WriteLine("Greater than 5");
            //System.Console.WriteLine("This always runs");

            // This is Good Practice and should be followed.
            if (value > 5)
            {
                System.Console.WriteLine("Greater than 5");
            }
            else
            {
                System.Console.WriteLine("Not greater than 5");
            }
        }
    }
}
