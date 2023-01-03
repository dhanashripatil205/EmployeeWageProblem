using EmployeeWageProblem;

namespace EmployeeWageNonStatic
{
    public class Method
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("***** Welcome to the employee wage computation Program for Static Methods. *****");

            EmployeeWageStatic bridge = new EmployeeWageStatic("BridgeLabz", 20, 10, 50);
            EmployeeWageStatic micro = new EmployeeWageStatic("MicroLand", 20, 10, 50);

            bridge.ComputeEmpWage();
            Console.WriteLine(bridge.Return());
            micro.ComputeEmpWage();
            Console.WriteLine(micro.Return());

        }
    }
}