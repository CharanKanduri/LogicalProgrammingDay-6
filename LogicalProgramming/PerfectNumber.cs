using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Number you want to check");
            int number = Convert.ToInt32(Console.ReadLine());
            PerfectNumberCheck(number);
        }
        public static void PerfectNumberCheck(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
            }
        }
    }
}
