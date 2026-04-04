namespace NameofDemo.Console
{
    // Use nameof() instead of hardcoding field names
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            // Bad Example (Hardcoded string)
            //System.Console.WriteLine(string.Format("Value: {0}", output));
            // or
            // throw new Exception("Invalid value for output");

            // Best Practice (nameof())
            //System.Console.WriteLine($"Value: {nameof(output)} = {output}");

            // Example (Exception case)
            // if (output < 0)
            //{
            //    throw new ArgumentException(nameof(output));
            //}


        }
    }
}
