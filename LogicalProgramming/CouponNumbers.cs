using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class CouponNumbers
    {
        public static void CouponGeneration()
        {
            //Input the limits and length

            int count = 0;

            Console.WriteLine("Length of coupon");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The lower limit");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The upper limit");
            int upperLimit = Convert.ToInt32(Console.ReadLine());
           

            //Creating object for Random Class 

            Random random = new Random();

            //Using hashset for avoiding duplicates 

            HashSet<int> randomNumbers = new HashSet<int>();

            while (randomNumbers.Count != length)
            {

                int freshNumber = random.Next(lowerLimit, upperLimit);
               // Console.WriteLine(freshNumber);
                count++;//Everytime Random Value is generated count gets increased

                randomNumbers.Add(freshNumber);
                

            }
            Console.WriteLine("Total Random Numbers needed was: "+count);
            DisplaySet(randomNumbers);
            
        }
        public static void DisplaySet(HashSet<int> collection)
        {
            
            foreach (int i in collection)
            {
                Console.Write("{0}", i);
            }
            
        }


    }
}
