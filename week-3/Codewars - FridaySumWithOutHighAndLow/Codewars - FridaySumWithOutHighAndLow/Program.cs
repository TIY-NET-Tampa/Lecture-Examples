using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars___FridaySumWithOutHighAndLow
{
    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return 0;
            }
            // sort the array
            Array.Sort(numbers);
            Console.WriteLine(numbers);
            // delete the first and the last one (highest and lowest)
            numbers[0] = 0;
            numbers[numbers.Length - 1] = 0;
            // sum the array
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            // return the array
            return sum;
        }
    }

    public static class Kata_Linq
    {
        public static int Sum(int[] numbers)
        {
            var highest = numbers.Max();
            var lowest = numbers.Min();
            var total = numbers.Sum() - highest - lowest;
            return total;
        }
    }










    public static class Kata_1
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return 0;
            }
            var highest = int.MinValue;
            var lowest = int.MaxValue;
            var total = 0;
            foreach (var num in numbers)
            {
                if (num > highest)
                {
                    highest = num;
                } 
                if (num < lowest)
                {
                    lowest = num;
                }
                total += num;
            }
            return total - highest - lowest;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kata.Sum(new int[]{6, 2, 34, 5, 7});
        }
    }
}
