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
            EmployeeWageArray employeeWageArray = new EmployeeWageArray();
            employeeWageArray.addCompany("Microsoft", 20, 15, 120);
            employeeWageArray.addCompany("Tesla", 30, 25, 200);
            employeeWageArray.WageCalculation();
        }
    }
}