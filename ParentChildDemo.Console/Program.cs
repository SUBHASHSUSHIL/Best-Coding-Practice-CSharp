namespace ParentChildDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sushil", "Thakur", "Developer");
            employee.GetFullName();
            System.Console.WriteLine(employee.GetFullName());
        }
    }
}
