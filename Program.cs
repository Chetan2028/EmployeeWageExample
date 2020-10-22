using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
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

            ///Generates three random values and according to the condition assigns employee working hours using switchh statement
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
            Console.WriteLine("Employee Wage : " + EMPLOYEE_WAGE_PER_HOUR * employeeHours);
        }
    }
}