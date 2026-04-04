namespace GuidBestPractices.Console
{
    // Avoid using new Guid()
    internal class Program
    {
        // Bad Examples
        // This is not unique 00000000-0000-0000-0000-000000000000, but rather a GUID with all zeros, which is not the same as an empty GUID.
        Guid id1 = new Guid();        // empty GUID
        Guid id2 = new Guid("text");  // risky / invalid

        // Correct Way (Use Guid.NewGuid()
        Guid id = Guid.NewGuid();


        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            var orderId = Guid.NewGuid();
            System.Console.WriteLine(orderId);
        }
    }
}
