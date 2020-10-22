using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;
        const int NUMBER_OF_WORKING_DAYS_PER_MONTH = 20;
        const int MAXIMUM_WORKING_HOURS = 100;
        const int MAXIMUM_WORKING_DAYS = 20;

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Variables
            int employeeHours = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;

            ///Create a reference of Random class
            Random random = new Random();

            ///Iterating till a certain condition is reached
            while (totalWorkingDays <= MAXIMUM_WORKING_DAYS && totalWorkingHours <= MAXIMUM_WORKING_HOURS)
            {
                totalWorkingDays++;
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
                        totalWorkingDays--;
                        break;
                }
                totalWorkingHours += employeeHours;
            }
            Console.WriteLine("Employee Wage : " + EMPLOYEE_WAGE_PER_HOUR * totalWorkingHours);
        }
    }
}