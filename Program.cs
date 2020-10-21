using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_PRESENT = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;

        ///Variables
        int employeeHours = 0;

        /// <summary>
        /// Checks the employee presence and calculates the wage 
        /// </summary>
        public void EmployeeCheckAndWageCalculator()
        {
            ///Create a reference of Random class
            Random random = new Random();
            ///random function generates two values and checks the condition
            if(random.Next(2) == IS_PRESENT)
            {
                employeeHours = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                employeeHours = 0;
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Employee Wage : " + EMPLOYEE_WAGE_PER_HOUR * employeeHours);
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ///Create a reference of Program class
            Program program = new Program();
            ///Call the function
            program.EmployeeCheckAndWageCalculator();
        }
    }
}
