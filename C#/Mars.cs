using System;

namespace Mars
{
    class Mars
    {
        static bool isValid(int year)
        {
            int month = 12 * (year - 1);
            for (int i = 1; i < 13; i++)
            {
                if((month+i-2)%26 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);
            if (isValid(inputInt))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
