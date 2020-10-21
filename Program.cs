using System;

namespace EmployeeWage
{
    class Program
    {
        ///Constants
        const int IS_PRESENT = 1;

        /// <summary>
        /// Checks the employee presence
        /// </summary>
        public void EmployeeCheck()
        {
            ///Create a reference of Random class
            Random random = new Random();
            ///random function generates two values and checks the condition
            if(random.Next(2) == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.EmployeeCheck();
        }
    }
}
