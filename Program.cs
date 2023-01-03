using EmployeeWageProblem;

namespace EmployeeWageNonStatic
{
    public class Method
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("***** Welcome to the employee wage computation Program for Static Methods. *****");

            EmployeeWageStatic bridge = new EmployeeWageStatic();
              bridge.addCompanyEmpWage("BridgeLabz", 20, 10, 50);
              bridge.addCompanyEmpWage("MicroLand", 20, 10, 50);
              bridge.computeEmpWage();

        }
    }
}