using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrollsys
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the weekly Salary:");
            double weeksal = double.Parse(Console.ReadLine());
            Salaried_Employee empSE = new Salaried_Employee(weeksal);
            empSE.empDetails();
            Console.WriteLine("Salaried employee earning:"+empSE.earning());
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Enter the working hours:");
            double hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the wage per day:");
            double wage = double.Parse(Console.ReadLine());
            Hourly_Employee empHE = new Hourly_Employee(hours, wage);
            empHE.empDetails();
            Console.WriteLine("Hourly employee earnings:" + empHE.earning());

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Enter the Commission rate:");
            double comRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gross Sales:");
            double grossSalse = double.Parse(Console.ReadLine());
            Commission_Employee empCE = new Commission_Employee(comRate, grossSalse);
            empCE.empDetails();
            Console.WriteLine("Commission  employee earnings:"+empCE.earning());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter the Basic Salary:");
            double baseSal = double.Parse(Console.ReadLine());
            Basic_Plus_Commission_Employee empBPCE = new Basic_Plus_Commission_Employee(comRate,grossSalse,baseSal);
            empBPCE.empDetails();
            Console.WriteLine("Basic plus commission employee earnings: " + empBPCE.earning());



            Console.ReadLine();
        }
    }
}
