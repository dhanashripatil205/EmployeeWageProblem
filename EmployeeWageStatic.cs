using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeWageProblem
{
    public class EmployeeWageStatic
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        private int NumOfComany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmployeeWageStatic()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];

        }

        public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hr, int Max_Days_In_Month, int Max_Hrs_In_Month)
        {
            companyEmpWageArray[this.NumOfComany] = new CompanyEmpWage(company, Emp_Rate_Per_Hr , Max_Days_In_Month , Max_Hrs_In_Month);
            NumOfComany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < NumOfComany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {


            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0; int totalSallery = 0; int totalDays = 0;


            Console.WriteLine();

            while (totalEmpHrs <= companyEmpWage.Max_Hrs_In_Month && totalWorkingDays < companyEmpWage.Max_Days_In_Month)
            {
                totalWorkingDays++;

                Random obj = new Random();
                int empcheck = obj.Next(0, 3);

                switch (empcheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        totalSallery = companyEmpWage.Emp_Rate_Per_Hr * empHrs;

                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        totalSallery = companyEmpWage.Emp_Rate_Per_Hr * empHrs;

                        break;

                    default:
                        empHrs = 0;
                        totalSallery = companyEmpWage.Emp_Rate_Per_Hr * empHrs;

                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                //Console.WriteLine("Day# : " + totalWorkingDays + "  Total employee hours are :- " + empHrs);
                if (totalEmpHrs <= companyEmpWage.Max_Hrs_In_Month)
                {
                    companyEmpWage.totalEmpWage += totalSallery;

                    Console.WriteLine("Day# : " + totalDays + " =>  emp Hrs : " + empHrs + " =>  EmpWage: " + totalSallery);
                }
            }
            return companyEmpWage.totalEmpWage;


        }
    }
}
