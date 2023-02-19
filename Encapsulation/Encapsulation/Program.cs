using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        private string employeeName;
        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeName = "Shraddha";
            Console.WriteLine("Employee Name is " + emp.EmployeeName);
        }
    }
}
}
