using System;
using System.Collections.Generic;

namespace Cups
{   /// <summary>
/// solution to Cups found at https://open.kattis.com/problems/cups
/// </summary>
    class Cups
    {

        /// <summary>
        /// read user inputs and output sorted list in Console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            int intTime = Convert.ToInt32(time);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            int[] arr = new int[intTime];

            for (int i = 0; i < intTime; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (isInt(input[0]))
                {
                    int num = Convert.ToInt32(input[0]) / 2;
                    arr[i] = num;
                    dict.Add(num, input[1]);
                }
                else
                {
                    int num = Convert.ToInt32(input[1]);
                    arr[i] = num;
                    dict.Add(num, input[0]);
                }
            }
            Array.Sort(arr);
            for (int i = 0; i < intTime; i++)
            {
                Console.WriteLine(dict[arr[i]]);
            }
        }

        /// <summary>
        /// isInt determines if input can be converted to an int
        /// </summary>
        /// <param name="input"> string type </param>
        /// <returns></returns>
        static bool isInt(string input)
        {
            int value;
            try
            {
                value = Int32.Parse(input);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
