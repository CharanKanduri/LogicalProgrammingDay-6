using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class FewestNotes
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the ammount");
            int amount = Convert.ToInt32(Console.ReadLine());
            FindFewestNotes(amount);
        }

        public static void FindFewestNotes(int n)
        {
            int[] currency = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1};

            int[] noteCounter = new int[9];

            for (int i = 0; i < 8; i++)
            {
                if (n >= currency[i])
                {
                    noteCounter[i] = n / currency[i];
                    n = n - noteCounter[i] * currency[i];
                }
            }
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(currency[i] + " : "
                        + noteCounter[i]);
                }
            }
        }

        
      
     }

}

