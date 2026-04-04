namespace SwitchRefactoringDemo.Console
{
    // Switch case should not have too many lines of code — use methods instead
    internal class Program
    {
        //Best Practice (Use Methods)
        private static void ProcessMorning()
        {
            System.Console.WriteLine("Its morning");
            System.Console.WriteLine("Lets do some breakfast");
            System.Console.WriteLine("and then plan for the day");
        }

        private static void ProcessAfternoon()
        {
            System.Console.WriteLine("Its afternoon");
            System.Console.WriteLine("Lets do some work");
            System.Console.WriteLine("and then plan for evening");
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            int input = 1;
            //switch (input)
            //{
            //    case 1:
            //        System.Console.WriteLine("Its morning");
            //        System.Console.WriteLine("Lets do some breakfast");
            //        System.Console.WriteLine("and then plan for the day");
            //        break;

            //    case 2:
            //        System.Console.WriteLine("Its afternoon");
            //        System.Console.WriteLine("Lets do some work");
            //        System.Console.WriteLine("and then plan for evening");
            //        break;

            //        // Problem: Too many lines of code in switch case
            //        // 1. Difficult to read and understand / Readability low
            //        // 2. Difficult to maintain and modify / Reusability zero
            //        // 3. Violates the Single Responsibility Principle
            //}

            // Best Practice
            //switch (input)
            //{
            //    case 1:
            //        ProcessMorning();
            //        break;

            //    case 2:
            //        ProcessAfternoon();
            //        break;

            //    default:
            //        System.Console.WriteLine("No input provided");
            //        break;
            //}


            // Next Level (BEST PRACTICE): Use Polymorphism and Strategy Pattern instead of switch case
            // Dictionary + Action (Advanced)
            var map = new Dictionary<int, Action>
            {
                { 1, ProcessMorning },
                { 2, ProcessAfternoon }
            };

            if (map.ContainsKey(input))
            {
                map[input]();
            }
            else
            {
                System.Console.WriteLine("No input provided");
            }
        }
    }
}
