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
            EmployeeWage google = new EmployeeWage("Google", 20, 24, 100);
            google.WageCalculation();

            EmployeeWage apple = new EmployeeWage("Apple", 25, 20, 150);
            apple.WageCalculation();
        }
    }
}