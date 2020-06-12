using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Hourly_Employee:Employee
    {
        double hours, wage;
        public Hourly_Employee(double h,double wg)
        {
            hours = h;
            wage = wg;
        }
        public double earning()
        {
            if (hours <= 40)
            {
                return (wage * hours);
            }
            else
            {
                return (40 * wage + (hours - 40) * wage * 1.5);
            }
        }
    }
}
