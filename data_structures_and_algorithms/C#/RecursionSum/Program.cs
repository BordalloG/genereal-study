using System;
using System.Linq;

namespace RecursiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new double[] { 10,20,30}));
        }

        static double Sum(double[] numbers)
        {
            if (numbers.Length == 1)
                return numbers[0];
            else
                return numbers[0] + Sum(numbers.Skip(1).Take(numbers.Length - 1).ToArray());
        }
    }
}
