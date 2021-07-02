using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class FibonociSeries
    {
        public static void ReadInput() 
        {
            Console.WriteLine("Welcome to Fibonoci Series Program");
            int length = Convert.ToInt32(Console.ReadLine());
            FindFibonociSeries(length);
        }
        private static void FindFibonociSeries(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int sum = 0;
            Console.Write(f1+" "+f2);

            for (int i = 2; i <= n; i++)
            {
                sum = f1 + f2;
                Console.Write(" "+sum);
                f1 = f2;
                f2 = sum;
            }
        }
    }
}
