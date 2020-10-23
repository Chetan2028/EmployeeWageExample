using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class EmployeeWageList : IComputeWage
    {
        ///Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageDict

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWageList"/> class.
        /// </summary>
        public EmployeeWageList()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageDict = new Dictionary<string, CompanyEmpWage>();
        }

        /// <summary>
        /// Adds the company to an Array List
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="maxWorkingDays">The maximum working days.</param>
        /// <param name="maxWorkingHours">The maximum working hours.</param>
        public void AddCompany(string company, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, maxWorkingDays, maxWorkingHours);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyEmpWageDict.Add(company, companyEmpWage);
        }

        /// <summary>
        /// This method calculates the wage
        /// </summary>
        public void WageCalculation()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmployeeWage(this.WageCalculation(companyEmpWage));
                Console.WriteLine(companyEmpWage.PrintTotalWage());
            }
        }
        /// <summary>
        /// Wages the calculation.
        /// </summary>
        /// <param name="companyEmpWage">The company emp wage.</param>
        /// <returns></returns>
        private int WageCalculation(CompanyEmpWage companyEmpWage)
        {
            ///Variables
            int employeeHours = 0;
            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            ///Computation
            while (totalWorkingHours < companyEmpWage.maxWorkingHours && totalWorkingDays < companyEmpWage.maxWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case IS_FULL_TIME:
                        employeeHours = 8;
                        break;
                    case IS_PART_TIME:
                        employeeHours = 4;
                        break;
                    default:
                        employeeHours = 0;
                        break;
                }
                totalEmpHrs += employeeHours;
                Console.WriteLine("Day" + totalWorkingDays + " for " + companyEmpWage.company + " is : " + employeeHours*companyEmpWage.empRatePerHour);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

        public int GetTotalWage(string company)
        {
            return this.companyEmpWageDict[company].totalEmployeeWage;
        }

    }
}
