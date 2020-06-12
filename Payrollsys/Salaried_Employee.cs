using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Salaried_Employee:Employee
    {
        double weeklysal;
        public Salaried_Employee(double w)
        {
            this.weeklysal = w;
        }
        public Double earning()
        {
            return weeklysal;
        }
    }
}
