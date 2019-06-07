using System;

namespace Pot
{
    /// <summary>
    /// solution to problem Pot found at https://open.kattis.com/problems/pot
    /// </summary>
    class Program
    {
        /// <summary>
        /// function to calculate each term for the sum
        /// </summary>
        /// <param name="num">
        /// string representing a number
        /// last digit of num is the exponent
        /// the rest is the base
        /// </param>
        /// <returns>
        /// a double of base to the power of exponent
        /// </returns>
        /// <example>
        /// <code>
        /// double ex = fix("22");
        /// Console.WriteLine(ex);
        /// </code>
        /// </example>
        static double fix(string num)
        {
            int i = 0;
            string baseNum = "";
            while (i < num.Length - 1)
            {
                baseNum += num[i];
                i++;
            }
            string exp = Convert.ToString(num[i]);
            return Math.Pow(Convert.ToInt32(baseNum), Convert.ToInt32(exp));

        }
        /// <summary>
        /// Main function calculate and output sum based on user input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count =Convert.ToInt32(Console.ReadLine());
            double ans = 0;

            for (int i = 0; i < count; i++)
            {
                ans += fix(Console.ReadLine());
            }
            Console.WriteLine(ans);
        }
    }
}
