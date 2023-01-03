using System.Runtime.CompilerServices;

namespace EmployeeWageProblem
{
    public class EmployeeWageStatic
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        private string company;
        private int Emp_Rate_Per_Hr;
        private int Max_Days_In_Month;
        private int Max_Hrs_In_Month;
        int totalEmpWage;

        public EmployeeWageStatic(string company, int Emp_Rate_Per_Hr, int Max_Days_In_Month, int Max_Hrs_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hr = Emp_Rate_Per_Hr;
            this.Max_Days_In_Month = Max_Days_In_Month;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;
        }
        public void ComputeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            Console.WriteLine();
            Console.WriteLine("@@@@@@@@@@@ " + company + " @@@@@@@@@@");

            while (totalEmpHrs <= this.Max_Hrs_In_Month && totalWorkingDays < this.Max_Days_In_Month)
            {
                totalWorkingDays++;

                Random obj = new Random();
                int empcheck = obj.Next(0, 3);

                switch (empcheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day# : " + totalWorkingDays + "  Total employee hours are :- " + empHrs);

            }
            totalEmpWage = totalEmpHrs * this.Emp_Rate_Per_Hr;
            Console.WriteLine("Total employee Wage is :- " + totalEmpWage);
        }

        public string Return()
        {
            return "Total employee wage of " + this.company + " is :-  " +this.totalEmpWage;

        }

    }
}
