using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        /// <summary>
        /// This method computes the wage for multiple companies
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numberOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void computeWage(string companyName, int empRatePerHour, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            ///Variables
            int employeeHours = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;

            ///Create a reference of Random class
            Random random = new Random();

            ///Iterating till a certain condition is reached
            while (totalWorkingDays <= numberOfWorkingDays && totalWorkingHours <= maxHoursPerMonth)
            {
                totalWorkingDays++;
                ///Generates three random values and according to the condition assigns employee working hours using switch statement
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
            Console.WriteLine("Employee Wage for " + companyName +" is " + empRatePerHour * totalWorkingHours);
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.computeWage("Apple", 20, 24, 35);
            program.computeWage("Google", 35, 20, 20);
        }
    }
}