using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    interface IComputeWage
    {
        public void AddCompany(string company, int empRatePerHour, int maxWorkingDays, int maxWorkingHours);
        public void WageCalculation();
        public int GetTotalWage(string company);
    }
}
