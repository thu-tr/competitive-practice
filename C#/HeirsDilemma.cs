using System;

namespace Heir
{
    /// <summary>
    /// Solution to problem Heir's Dilemma found at https://open.kattis.com/problems/heirsdilemma
    /// </summary>
    class Program
    {
        /// <summary>
        /// function helper determines if the input number has distinct digits and is divisible by all of its digits
        /// </summary>
        /// <param name="x">input integer</param>
        /// <returns>true or false</returns>
        static bool helper(int x)
        {
            int number = x;
            int[] tracker = new int[10];
            while (number > 0)
            {
                int digit = number % 10;
                if (digit == 0)
                {
                    return false;
                }
                else if (tracker[digit] > 0)
                {
                    return false;
                }
                else if (x % digit != 0)
                {
                    return false;
                }
                else
                { 
                    tracker[digit]++;
                    number = number / 10;
                }
            }
            return true;
        }

        /// <summary>
        /// main function takes 2 integer as inputs
        /// and outputs the number of numbers between the inputs' range that satisfy the criteria above
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            int start = Convert.ToInt32(num[0]);
            int end = Convert.ToInt32(num[1]);
            int count = 0;
            for (int i = start; i < end+1; i++)
            {
                if (helper(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
