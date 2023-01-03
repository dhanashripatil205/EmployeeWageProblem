using EmployeeWageProblem;

namespace EmployeeWageNonStatic
{
    public class Method
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("***** Welcome to the employee wage computation Program for Static Methods. *****");

            EmployeeWageStatic.Employee("BridgeLabz", 40, 15, 100);
            EmployeeWageStatic.Employee("Microland", 40, 20, 150);
            EmployeeWageStatic.Employee("Karvy", 20, 5, 50);
        }
    }
}