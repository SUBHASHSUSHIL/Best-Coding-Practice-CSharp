namespace MethodRefactoringDemo.Console
{
    // Functions should not be too big
    internal class Program
    {
        // Bad Example (Long method)
        // Reading this method, you have no idea what it does without reading the whole thing
        // It does too many things, it has too many responsibilities
        // It is not testable, it is not maintainable, it is not readable
        public void ProcessOrder()
        {
            // validation
            // calculation
            // payment
            // logging
            // email sending
            // 50+ lines 😵
        }

        // Best Practice (Refactored method)
        // One method should do one thing, and do it well
        // It is more readable, it is more maintainable, it is more testable
        // Each method has a single responsibility, and the main method orchestrates the flow
        //public void ProcessOrder()
        //{
        //    ValidateOrder();
        //    CalculateTotal();
        //    ProcessPayment();
        //    SendEmail();
        //}

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
