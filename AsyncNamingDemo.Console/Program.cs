namespace AsyncNamingDemo.Console
{
    // Async method should have Async suffix
    internal class Program
    {
        // Bad Example
        //public static string DoSomething()  // This method is not async but has a name that suggests it is.
        //{
        //    return "";
        //}

        // Confusing Example
        //public static Task<string> DoSomething() // This method is async but does not have the Async suffix, which can be misleading.
        //{
        //    return await httpClient.GetStringAsync();
        //}

        // Correct Naming
        public static async Task<string> DoSomethingAsync()
        {
            return await new HttpClient().GetStringAsync("url");
        }

       // Problem agar suffix nahi lagaya
            // Developer confuse ho jayega:
            // await karna hai ya nahi?

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            //DoSomething();        // sync
            DoSomethingAsync(); // async
        }
    }   
}
