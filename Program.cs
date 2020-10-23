using System;

namespace EmployeeWage
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            EmployeeWageList employeeWageList = new EmployeeWageList();
            employeeWageList.AddCompany("Microsoft", 20, 15, 120);
            employeeWageList.AddCompany("Tesla", 30, 25, 200);
            employeeWageList.WageCalculation();
        }
    }
}