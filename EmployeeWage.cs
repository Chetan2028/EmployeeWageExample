using System;

namespace EmployeeWage
{
    class EmployeeWage
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;

        /// Variables
        String companyName;
        int empRatePerHour;
        int maxWorkingDays;
        int maxWorkingHours;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeWage"/> class.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="maxWorkingDays">The maximum working days.</param>
        /// <param name="maxWorkingHours">The maximum working hours.</param>
        public EmployeeWage(String companyName, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        /// <summary>
        /// This method calculate the employee wage
        /// </summary>
        public void WageCalculation()
        {
            ///Variables
            int employeeHours = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;

            ///Create a reference of Random class
            Random random = new Random();

            ///Iterating till a certain condition is reached
            while (totalWorkingDays <= maxWorkingDays && totalWorkingHours <= maxWorkingHours)
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
            Console.WriteLine("Employee Wage for " + companyName + " is " + empRatePerHour * totalWorkingHours);
        }

    }
}
