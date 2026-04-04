namespace IfStatementOptimizationDemo.Console
{
    internal class Program
    {

        //Merge nested if statements to improve readability

        //public void DoOperation(int n1, int n2)
        //{
        //    if (n1 > 5)
        //    {
        //        if(n2 < 10)
        //        {
        //            // Do Something
        //        }
        //    }
        //}

        public void DoOperation(int n1, int n2)
        {
            if (n1 > 5 && n2 < 10)
            {
                // Do Something
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
