using System;
using System.Collections.Generic;
using System.Linq;

namespace Lamda_expressions_for_strings
{
    class Student
    {

        
        public int rollNo
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

    class Program
    {

        
        static void Main(string[] args)
        {
            
            List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "pranathi" },
                new Student{ rollNo = 2, name = "ananya" },
                new Student{ rollNo = 3, name = "Tina" },
                new Student{ rollNo = 4, name = "zefron" },
                new Student { rollNo = 5, name = "Taman" }
        };

            // To sort the details list based on name of student in acsending order 
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
        }
    }
}