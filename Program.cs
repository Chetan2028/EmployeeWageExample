using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;
        const int NUMBER_OF_WORKING_DAYS = 20;

        ///Variables
        int employeeHours = 0;
        int totalSalary = 0;

        ///Create a reference of Random class
        Random random = new Random();

        public void CalculateMonthlyWages()
        {
            for (int index = 1; index <= NUMBER_OF_WORKING_DAYS; index++)
            {
                ///random function generates three values and checks the condition
                if (random.Next(0, 3) == IS_FULL_TIME)
                {
                    employeeHours = 8;
                }
                else if (random.Next(0, 3) == IS_PART_TIME)
                {
                    employeeHours = 4;
                }
                else
                {
                    employeeHours = 0;
                }
                totalSalary += (employeeHours * EMPLOYEE_WAGE_PER_HOUR);
            }
            Console.WriteLine("Total Salary of Employees is : " + totalSalary);
        }
        /// <summary>
        /// Calculates the wage using switch statement
        /// </summary>
        public void CalculateWageUsingSwitch()
        {
            switch (random.Next(0, 3))
            {
                case 2:
                    Console.WriteLine("Employee is Full Time");
                    employeeHours = 8;
                    break;
                case 1:
                    Console.WriteLine("Employee is Part Time");
                    employeeHours = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            Console.WriteLine("Employee Wage : " + employeeHours * EMPLOYEE_WAGE_PER_HOUR);
        }

        /// <summary>
        /// Checks the employee presence and calculates the wage 
        /// </summary>
        public void EmployeeCheckAndWageCalculator()
        {
            ///random function generates three values and checks the condition
            if (random.Next(0, 3) == IS_FULL_TIME)
            {
                employeeHours = 8;
                Console.WriteLine("Employee is Full Time");
            }
            else if (random.Next(0, 3) == IS_PART_TIME)
            {
                employeeHours = 4;
                Console.WriteLine("Employee is Part Time");
            }
            else
            {
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
            ///Call the function to calculate wage
            program.EmployeeCheckAndWageCalculator();
            ///Call the function to calculate wage using switch statement
            program.CalculateWageUsingSwitch();
            ///Call the function to calculate monthly wage
            program.CalculateMonthlyWages();
        }
    }
}
