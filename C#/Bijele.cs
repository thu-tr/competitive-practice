using System;

namespace Bijele
{
    /// <summary>
    /// Solution to problem Bijele found at https://open.kattis.com/submissions/4240300
    /// </summary>
    class Bijele
    {
        /// <summary>
        /// main function takes in user input
        /// and output a series of numbers of pieces needed for a complete set
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int[] enough = { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i <6; i++)
            {
                int ans = enough[i] - Convert.ToInt32(tokens[i]);
                Console.Write(ans);
                if (i != 5)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
