using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PrimeNumbercs
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter The Number you want to check");
            int number = Convert.ToInt32(Console.ReadLine());
            PrimeNumberCheck(number);
        }

        public static void PrimeNumberCheck(int n)
        {
            int i;
            int primeCheck = 1;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    
                    primeCheck = 0;
                    break;
                }
            }
            if (primeCheck == 1)
            {
                Console.WriteLine("This is a Prime number");
            }
            else 
            {
                Console.WriteLine("This is a composite number");
            }
              
            

           
        }
    }
}
