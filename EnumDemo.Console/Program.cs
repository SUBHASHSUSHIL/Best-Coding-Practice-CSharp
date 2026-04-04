namespace EnumDemo.Console
{
    internal class Program
    {
        public enum DaysOfWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        public void GetWeekday(Int32 weekdays)
        {
            DaysOfWeek daysOfWeek = (DaysOfWeek)weekdays;
            PrintDay(daysOfWeek);
        }

        public void PrintDay(DaysOfWeek day)
        {
            System.Console.WriteLine($"The day of the week is: {day}");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetWeekday(3);
        }
    }
}
