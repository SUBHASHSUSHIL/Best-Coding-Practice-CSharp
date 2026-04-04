namespace MethodParameterDemo.Console
{
    internal class Program
    {

        //Don’t have too many method parameters

        //public static int ProcessLogic(int number1, int number2, int number3, int number4, int number5, int number6, int number7)
        //{
        //    int value1 = number1 + number2;
        //    int value2 = number3 * number4;
        //    int value3 = number5 - number6;
        //    int value4 = number7 * number5;

        //    return (value1 / value2) * (value3 + value4);
        //}

         public static int ProcessLogic(CalculationInput input)
        {
            int value1 = input.Number1 + input.Number2;
            int value2 = input.Number3 * input.Number4;
            int value3 = input.Number5 - input.Number6;
            int value4 = input.Number7 * input.Number5;

            return (value1 / value2) * (value3 + value4);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            var input = new CalculationInput
            {
                Number1 = 10,
                Number2 = 20,
                Number3 = 5,
                Number4 = 4,
                Number5 = 15,
                Number6 = 3,
                Number7 = 8
            };

            System.Console.WriteLine(ProcessLogic(input));
        }
    }

    class CalculationInput
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public int Number5 { get; set; }
        public int Number6 { get; set; }
        public int Number7 { get; set; }
    }
}
