using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_PRESENT = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Variables
            int employeeHours = 0;

            ///Create a reference of Random class
            Random random = new Random();

            ///Generates two random values and according to the condition assigns employee working hours
            if (random.Next(0, 2) == IS_PRESENT)
            {
                employeeHours = 8;
            }
            else
            {
                employeeHours = 0;
            }
            Console.WriteLine("Employee Wage : " + EMPLOYEE_WAGE_PER_HOUR * employeeHours);
        }
    }
}