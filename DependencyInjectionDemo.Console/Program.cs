namespace DependencyInjectionDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            IEngine engine = new PetrolEngine();
            Car car = new Car(engine);

            car.Start();
        }

        // DI:- 
        // Loosely coupled, easier to test, more maintainable, better separation of concerns, and improved flexibility.
    }
}
