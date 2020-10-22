using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class EmployeeWageArray
    {
        ///Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWageArray"/> class.
        /// </summary>
        public EmployeeWageArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[10];
        }

        /// <summary>
        /// Adds the company to an array
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="maxWorkingDays">The maximum working days.</param>
        /// <param name="maxWorkingHours">The maximum working hours.</param>
        public void addCompany(string company, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, maxWorkingDays, maxWorkingHours);
            numOfCompany++;
        }

        /// <summary>
        /// This method calculates the wage
        /// </summary>
        public void WageCalculation()
        {
            for (int index = 0; index < numOfCompany; index++)
            {
                companyEmpWageArray[index].SetTotalEmployeeWage(this.WageCalculation(this.companyEmpWageArray[index]));
                Console.WriteLine(this.companyEmpWageArray[index].ToString());
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
                Console.WriteLine("Day " + totalWorkingDays + " Employee Hours : " + employeeHours);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
