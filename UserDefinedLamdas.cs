using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class UserDefinedLamdas
    {
        /*static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{empId=110,name="John"},
                new Employee{empId=104,name="Stewart"},
                new Employee{empId=102,name="Tina"},
                new Employee{empId=154,name="Stefani"},
                new Employee{empId=175,name="Trish"},
                new Employee{empId=106,name="Ale"}
            };

            var nameSorted = employees.OrderBy(emp => emp.name);
            Print(nameSorted);

            var idSorted = employees.OrderBy(emp => emp.empId);
            Print(idSorted);
        }*/

        public IEnumerable<Employee> sortByName(List<Employee> employees) { 
            return employees.OrderBy(emp => emp.name); ;
        }

        public IEnumerable<Employee> sortById(List<Employee> employees)
        {
            return employees.OrderBy(emp => emp.name); ;
        }
        static void Print(IOrderedEnumerable<Employee> raw) {
            foreach (var value in raw)
            {
                Console.WriteLine(value.empId + " " + value.name);
            }
        }
    }

    class Employee
    {
        public int empId 
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
    }
}
