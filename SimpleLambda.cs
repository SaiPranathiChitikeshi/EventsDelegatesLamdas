using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Assert = NUnit.Framework.Assert;

namespace TestApp
{
    class SimpleLambda
    {
        /*static void MainTest(string[] args)
        {
            //dataset
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            //Console.WriteLine(String.Join(", ", numbers));
            //numbers.ForEach(Console.Write);
            Console.WriteLine("Data Set using lamdas");
            Each(numbers, i => Console.WriteLine(i));
            Console.WriteLine("square of numbers");
            var square = numbers.Select(number => number * number);
            Each(square, i => Console.WriteLine(i));
            Console.WriteLine("Even numbers");
            var even = numbers.FindAll(x => (x % 2) == 0);
            Each(even, i => Console.WriteLine(i));
            Assert.IsTrue(true);

        }*/
        public IEnumerable<int> EvenNumbers(List<int> numbers){
            return numbers.FindAll(number => (number % 2) == 0);
        }

        public IEnumerable<int> SquareNumber(List<int> numbers) {
            return numbers.Select(number => number * number);
        }

        public  void Each<T>(IEnumerable<T> items, Action<T> action){
            foreach (var item in items)
                action(item);
        }
    }
}
