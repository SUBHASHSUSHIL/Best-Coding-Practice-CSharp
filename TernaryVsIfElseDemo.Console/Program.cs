namespace TernaryVsIfElseDemo.Console
{
    // Ternary operators should not be nested
    internal class Program
    {
        // What is Ternary operator?
        // Syntax: condition ? value1 : value2;

        // BAD Example - Nested Ternary operator
        // Readability zero - you have to read the entire statement to understand it
        // Debugging difficult
        // Maintenance is difficult - if you want to change the logic, you have to change the entire statement

        //returnValue = input >= 1 && input <= 5 ? "Range 1" :
        //      input > 5 && input <= 10 ? "Range 2" :
        //      "Range 3";


        // GOOD Example - Using if-else statements
        // Readability is good - you can understand the logic by reading the statements
        // Debugging is easier - you can set breakpoints on individual statements
        // Maintenance is easier - you can change the logic of individual statements without affecting the entire logic

        //public string DoSomething(int input)
        //{
        //    string returnValue;

        //    if (input >= 1 && input <= 5)
        //    {
        //        returnValue = "Range 1";
        //    }
        //    else if (input > 5 && input <= 10)
        //    {
        //        returnValue = "Range 2";
        //    }
        //    else
        //    {
        //        returnValue = "Range 3";
        //    }

        //    return returnValue;
        //}

        // Even better - Using early returns
        public string DoSomething(int input)
        {
            if (input >= 1 && input <= 5)
                return "Range 1";

            if (input > 5 && input <= 10)
                return "Range 2";

            return "Range 3";
        }

        // when to use ternary operator?
        // string result = age > 18 ? "Adult" : "Minor";

        // Avoid when nested
        // a ? b : c ? d : e     // this confusing and hard to read

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
