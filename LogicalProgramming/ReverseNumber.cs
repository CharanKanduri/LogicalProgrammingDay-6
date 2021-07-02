using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Number you want to check");
            int number = Convert.ToInt32(Console.ReadLine());
            PerformReverseNumber(number);
        }

       public static void PerformReverseNumber(int n)
        {
            int reverseNumber = 0;
            
            while (n > 0)
            {
               
                reverseNumber = reverseNumber * 10 + n%10;
                n = n / 10;

            }
            Console.WriteLine(reverseNumber);

        }
    }
}
