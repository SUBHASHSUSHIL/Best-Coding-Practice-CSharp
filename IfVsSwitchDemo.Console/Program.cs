using System.Runtime.Intrinsics.X86;

namespace IfVsSwitchDemo.Console
{
    //Use switch for at least 3 cases, otherwise use if-else
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            // Bad Example (Switch for few cases)
            //int x = 5;

            //switch (x)
            //{
            //    case 5:
            //        System.Console.WriteLine("Five");
            //        break;

            //    case 10:
            //        System.Console.WriteLine("Ten");
            //        break;
            //}

            // Better(Use if-else)
            //if (x == 5)
            //{
            //    System.Console.WriteLine("Five");
            //}
            //else if (x == 10)
            //{
            //    System.Console.WriteLine("Ten");
            //}

            // When to use switch  -- then multiple fixed values ho
            int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        System.Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        System.Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        System.Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        System.Console.WriteLine("Thursday");
            //        break;

            //    default:
            //        System.Console.WriteLine("Invalid");
            //        break;
            //}

            // Better (Use switch expression) -- when we want to return a value based on multiple fixed values (Modern C# feature)
            int x = 5;
            string result = x switch
            {
                5 => "Five",
                10 => "Ten",
                _ => "Unknown"
            };

            System.Console.WriteLine(result);
        }
    }
}
