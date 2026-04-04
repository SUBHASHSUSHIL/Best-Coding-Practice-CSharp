namespace TodoFixmeDemo.Console
{
    internal class Program
    {
        public Boolean IsValid(Int32 number1, Int32 number2)
        {
            number2 += 55;
            // TODO: Add validation for number1 (avoid divide by zero)
            number2 = number1 * 2;

            // TODO: This logic needs more review and testing
            return number2 / number1 == 5;
        }

        //public bool IsValid(int number1, int number2)
        //{
        //    // TODO: Add validation for input values

        //    if (number1 == 0)
        //    {
        //        // FIXME: Proper error handling required (currently just returning false)
        //        return false;
        //    }

        //    number2 = number1 * 2;

        //    // TODO: Confirm business logic (why result should be 5?)
        //    return number2 / number1 == 5;
        //}


        //public string GetName(Int32 id)
        //{
        //    string name = GetNameFromDB(id);
        //    if(name.Length > 0)
        //    {
        //        return name;
        //    }
        //    else
        //    {
        //        // FIXME: Need to fetch a default name from a proper repository
        //        return "NoName";
        //    }
        //}

        public string GetName(int id)
        {
            string name = GetNameFromDB(id);

            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }

            // FIXME: Replace hardcoded "NoName" with proper default from database
            return "NoName";
        }

        // Clear hai kya karna hai (Matlab jo bhi karna hain ushe clear likho)
        // TODO (Sushil): Add input validation before division
        // FIXME (High Priority): Handle null response from database


        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
