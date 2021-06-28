using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPeople
{
    public class CalcNumber
    {

        public static double Addition(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;//sum = sum + num;
            }

            return sum;
        }

        public static void Exampel()
        {
            double[] numbers = new double[] { 1, 2, 3 };
            double result = CalcNumber.Addition(numbers);
            Console.WriteLine("sum: " + result);

            result = CalcNumber.Addition(6.0, 60.0, 600.0);
            Console.WriteLine("sum: " + result);

            result = CalcNumber.Addition(6.0, 60.0);
            Console.WriteLine("sum: " + result);

            //more info at https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params
        }
    }
}
