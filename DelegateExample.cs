using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class DelegateExample
    {
        public delegate int addNum(int num1,int num2);
        public delegate int subNum(int num1, int num2);
        public int sum(int num1, int num2) {
            return num1 + num2;
        }

        public int substract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static void main(string[] args)
        {
            DelegateExample deleg = new DelegateExample();
            addNum dele_obj = new addNum(deleg.sum);
            subNum dele_obj1 = new subNum(deleg.substract);
            Console.WriteLine(dele_obj(10, 15));
            Console.WriteLine(dele_obj1(10, 15));
        }
    }
}
