using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Employee
    {
       public void empDetails()
        {
            Console.WriteLine("Enter the employeee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the employee ID:");
            int id = int.Parse(Console.ReadLine());
        }
    }
}
