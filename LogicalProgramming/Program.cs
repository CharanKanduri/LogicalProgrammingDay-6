using System;

namespace LogicalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the required option\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a number\n5.Coupon Numbers\n6.Simulate Stopwatch Program\n7.Find the Fewest Notes to be returned for Vending Machine\n8.dayOfWeek\n9.temperaturConversion\n10.monthlyPayment\n11.sqrt\n12.toBinary");
            int inputNumber =Convert.ToInt32( Console.ReadLine());

            switch (inputNumber)
            {
                case 1:
                    FibonociSeries.ReadInput();
                    break;
                case 2:
                    PerfectNumber.ReadInput();
                    break;
                case 3:
                    PrimeNumbercs.ReadInput();
                    break;
                case 4:
                    ReverseNumber.ReadInput();
                    break;
                case 5:
                    CouponNumbers.CouponGeneration();

                    break;
                case 6:
                    Timer.StopWatch();
                    break;
                case 7:
                    FewestNotes.ReadInput();
                    break;
                case 8:
                    DayOfWeek.ReadInput();
                    break;
                case 9:
                    TemperaturConversion.ReadInput();
                    break;
                case 10:
                    MonthlyPayment.ReadInput();
                    break;
                case 11:
                    NewtonMethod.ReadInput();
                    break;
                case 12:
                    DecimalToBinary.ReadInput();
                    break;
                case 13:
                    Nibbles.ReadInput();
                    break;

                default:
                    Console.WriteLine("Select Correct Option");
                    break;
            }
           

        }
    }
}
