namespace VariableDeclarationDemo.Console
{
    internal class Program
    {
        //public int DoOperation()
        //{
        //    int n1, n2, n3, n4;
        //    int breakerValue;

        //    n1 = 5;
        //    n2 = 12;
        //    breakerValue = 22;
        //    n3 = n1 + n2;
        //    n4 = n3 * breakerValue;

        //    return n4;
        //}

        public int DoOperation()
        {
            int number1 = 5;  // Meaningful names and all variables not inialize single lines
            int number2 = 12;
            int breakerValue = 22;

            int sum = number1 + number2;
            int result = sum * breakerValue;

            return result;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
