using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        /// Variables
        public string company;
        public int maxWorkingHours;
        public int maxWorkingDays;
        public int empRatePerHour;
        public int totalEmployeeWage;

        public CompanyEmpWage(string company, int empRatePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }

        public void SetTotalEmployeeWage(int totalEmployeeWage)
        {
            this.totalEmployeeWage = totalEmployeeWage;
        }

        override
        public string ToString()
        {
            return "Total Employee Wage for" + this.company + " is " + this.totalEmployeeWage;
        }
    }
}
