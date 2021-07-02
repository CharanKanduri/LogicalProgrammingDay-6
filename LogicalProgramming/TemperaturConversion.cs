using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class TemperaturConversion
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Temperature");
            int temperature = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Enter your chioce\n1.Celsius to Fahrenheit\n2.Fahrenheit to Celsius:");
            int conversionChoice = Convert.ToInt32(Console.ReadLine());
            TemperatureChange(temperature,conversionChoice);
        }
        public static void TemperatureChange(int t,int c)
        {
            Double finalTempetature;
            if (c == 1)
            {
                finalTempetature= (t*1.8) +32;
                Console.WriteLine("Its" + finalTempetature + "Fahrenheit");
            }
            if (c == 2)
            {
                finalTempetature = (t-32)* 0.5 ;
                Console.WriteLine("Its "+finalTempetature+" Celsius");
            }

            
        }
    }
}
