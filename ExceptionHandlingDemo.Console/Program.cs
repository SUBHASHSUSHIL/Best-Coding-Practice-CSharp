namespace ExceptionHandlingDemo.Console
{
    // Never have empty catch blocks
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            //Bad Example
            try
            {
                // Do something important
            }
            catch (Exception ex)
            {
                // ❌ kuch bhi nahi kiya
            }

            // Good Example (Write to log, rethrow, or handle the exception appropriately)
            try
            {
                // Do something important
            }
            catch (Exception ex)  // Log error Only
            {
                System.Console.WriteLine(ex.Message);
            }

            // Better Example (Handle the exception or rethrow it)
            try
            {
                // Do something important

            }
            catch (Exception ex)
            {
                throw;
            }

            // Best Example (Handle specific exceptions and provide meaningful feedback) / Log + throw
            //try
            //{
            //    // Do something important
            //}
            //catch (ArgumentNullException ex)
            //{
            //    System.Console.WriteLine("A required argument was null: " + ex.Message);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    System.Console.WriteLine("An invalid operation occurred: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    LogError(ex);
            //    throw;
            //}
        }
    }
}
