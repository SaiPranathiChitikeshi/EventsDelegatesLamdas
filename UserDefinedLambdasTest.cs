using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class UserDefinedLambdasTest
    {
        [TestMethod]
        public void SortByIdTest()
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
            UserDefinedLamdas lamdas = new UserDefinedLamdas();
            var idSorted = lamdas.sortById(employees);
            Assert.AreEqual(idSorted.ElementAt(0).empId, 102);
        }

        [TestMethod]
        public void SortByNameTest()
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
            UserDefinedLamdas lamdas = new UserDefinedLamdas();
            var nameSorted = lamdas.sortByName(employees);
            Assert.AreEqual(nameSorted.ElementAt(0).name, "Ale");
        }
    }
}
