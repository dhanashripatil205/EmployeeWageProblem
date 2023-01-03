using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    
    public class CompanyEmpWage
    {
        public string company;
        public int Emp_Rate_Per_Hr;
        public int Max_Days_In_Month;
        public int Max_Hrs_In_Month;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int Emp_Rate_Per_Hr, int Max_Days_In_Month, int Max_Hrs_In_Month)
        {

            this.company = company;
            this.Emp_Rate_Per_Hr = Emp_Rate_Per_Hr;
            this.Max_Days_In_Month = Max_Days_In_Month;
            this.Max_Hrs_In_Month = Max_Hrs_In_Month;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total employee wage of " + this.company + " is :-  " + this.totalEmpWage;
        }

    }
}
