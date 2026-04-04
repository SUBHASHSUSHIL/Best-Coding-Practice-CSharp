namespace SwitchVsDictionaryDemo.Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            // Avoid using switch blocks with too many case blocks
            int input = 1;

            //switch (input)
            //{
            //    case 1:
            //        System.Console.WriteLine("Its Morning");
            //        break;

            //    case 2:
            //        System.Console.WriteLine("Its Afternoon");
            //        break;

            //    case 3:
            //        System.Console.WriteLine("Its Evening");
            //        break;

            //    case 4:
            //        System.Console.WriteLine("Its Night");
            //        break;

            //    default:
            //        System.Console.WriteLine("No input provided");
            //        break;
            //}

            // Best Practice (Use Dictionary)
            var dayTimeMap = new Dictionary<int, string>
                {
                    { 1, "Its Morning" },
                    { 2, "Its Afternoon" },
                    { 3, "Its Evening" },
                    { 4, "Its Night" }
                };

            if (dayTimeMap.ContainsKey(input))
            {
                System.Console.WriteLine(dayTimeMap[input]);
            }
            else
            {
                System.Console.WriteLine("No input provided");
            }
        }
    }
}
