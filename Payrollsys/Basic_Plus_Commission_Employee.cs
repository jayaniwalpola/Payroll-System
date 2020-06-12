using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Basic_Plus_Commission_Employee:Commission_Employee
    {
        double basicSalary;

        public Basic_Plus_Commission_Employee(double comRate,double grossRate, double BS):base(comRate,grossRate)
        {
            basicSalary = BS;
        }
        public double earning()
        {
            return ((commissionRate * grossSales) + basicSalary);
        }

    }
}
