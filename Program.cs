namespace EmployeeWageProblem
{
    public class Wage
    {
        public static void Main(string[] args)
        {
            Employee obj = new Employee();

            obj.addCompanies("deloitte", 20, 15, 90);

            obj.addCompanies("Reliance", 45, 23, 150);

            obj.EmpComputation();

        }
    }
}