using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the value of P ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of R");
            int r = Convert.ToInt32(Console.ReadLine());
            FindMonthlyPayments(p, y, r);
        }
        public static void FindMonthlyPayments(int p, int y, int r)
        {
            int tempR=r/1200;
            int tempN=12*y;

            int numerator = (p * tempR);
            double denominator = 1- 1/(Math.Pow(1+tempR, tempN));
            double finalAnswer = numerator / denominator;
            Console.WriteLine(finalAnswer);
        }

       
    }      
 } 
