using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Commission_Employee:Employee
    {
        protected double commissionRate, grossSales;
        public Commission_Employee(double cr,double gs)
        {
            commissionRate = cr;
            grossSales = gs;
        }
        public double earning()
        {
            return (commissionRate * grossSales);
        }
    }
}
