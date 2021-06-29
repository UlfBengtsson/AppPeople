using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppPeople
{
    public class CalcNumber
    {

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

        public static double Addition(params double[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;//sum = sum + num;
            }

            return sum;
        }

        public static double Subtration(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum -= numbers[i];
            }

            return sum;
        }

        public static double Multiplication(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum *= numbers[i];
            }

            return sum;
        }

        public static double Divide(params double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }          

            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException("This calculator will not devide by zero.");
                }
                sum /= numbers[i];
            }

            return sum;
        }
    }
}
