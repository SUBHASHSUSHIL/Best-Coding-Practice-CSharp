namespace CleanCodeDemo.Console
{
    internal class Program
    {
        // Never leave commented-out code if you are using a source control system
        public int Calculate()
        {
            int result = 0;
            int a = 0;
            int b = 0;

            // Old code ko comment karke mat rakho (Bad Example (Common Mistake))
            // Old logic (not used anymore)
            // result = a + b;

            // New logic
            result = a * b;

            return result;
        }

        // Correct Way
        //public int Calculate()
        //{
        //    int a = 0;
        //    int b = 0;

        //    int result = a * b;
        //    return result;
        //}

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
