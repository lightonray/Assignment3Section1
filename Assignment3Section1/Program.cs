using System;
using System.Linq;

namespace Assignment3MaxMinSumAverageOfArray
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                double[] numbers = new double[4];

                Console.WriteLine("Please insert four numbers");

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }

                double max = numbers.Max();
                double min = numbers.Min();
                double sum = numbers.Sum();
                double average = (double)numbers.Average();

                Console.WriteLine("Max value is: " + max + "\nMin value is: " + min + "\nThe sum is: " + sum + "\nThe average is: " + average);
            }
            catch
            {
                Console.Write("Please enter a valid value");
            }
        }
    }
}
