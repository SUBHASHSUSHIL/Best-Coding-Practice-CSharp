namespace NamingConventionDemo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }

    //Bad Naming (Wrong)
    class person
    {
        public string name { get; set; }

        public string getname()
        {
            return name;
        }
    }

    //Good Naming (Right)/ Correct Naming (PascalCase)
    class Person
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }
    }

    // Rules yaad rakho
    // 1. Class names → PascalCase 
    // class Person
    // class EmployeeDetails

    // 2. Method names → PascalCase
    // public string GetName()
    // public void CalculateSalary()

    // 3. Property names → PascalCase
    // public string Name { get; set; }

    // 4. Variable names → camelCase
    // string firstName;
    // int employeeId;

    // 5. Constants → UPPER_SNAKE_CASE
    // const int MAX_EMPLOYEES = 100;

    // 6. Avoid abbreviations and acronyms
    // string customerAddress; // Not custAddr

    // 7. Be descriptive and meaningful
    // string employeeName; // Not empName

    // 8. Avoid using reserved keywords
    // string class; // Not allowed

    // 9. Consistency is key
    // Follow the same naming convention throughout your codebase for better readability and maintainability.

    // 10. Avoid using underscores in variable names (except for constants)
    // string first_name; // Not recommended

    // 11. Use singular nouns for class names
    // class Employee
    // class Product

    // 12. Use verbs for method names
    // public void CalculateSalary()
    // public string GetName()

    // 13. Avoid using numbers in variable names
    // string name1; // Not recommended

    // 14. Use meaningful names for boolean variables
    // bool isActive; // Not isAct

    // 15. Avoid using Hungarian notation (prefixes like str, int, etc.)
    // string strName; // Not recommended

    // 16. Use namespaces to organize your code
    // namespace MyCompany.Project.Module

    // 17. Avoid using single-character variable names (except for loop counters)
    // for (int i = 0; i < 10; i++) { } // Acceptable for loop counters

    // 18. Use descriptive names for event handlers
    // void OnButtonClick(object sender, EventArgs e)

    // 19. Avoid using underscores in method names
    // public void Calculate_Salary() // Not recommended

    // 20. Use PascalCase for enum names and values
    // enum EmployeeType
    // {
    //     FullTime,
    //     PartTime,
    //     Contractor
    // }
}
