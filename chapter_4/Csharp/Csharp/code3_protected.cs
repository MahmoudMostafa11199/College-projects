using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Employee
    {
        public string empName ;
        public int empID  = 100;
        protected Single carPay;
        protected int empAge ;
        protected string companyName ;

        public void m()
        {
            carPay = 1008;
            Console.WriteLine(carPay);
        }
    }

    class manager:Employee
    {
        public void n()
        {
            Console.WriteLine(empAge + "\n");
        }

    }
    class code3_protected
    {
        public static void display()
        {
            Employee objEmp = new Employee();
            manager objMan = new manager();
            objEmp.m();
            objMan.n();
        }
    }
}
