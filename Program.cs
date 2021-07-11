using System;

namespace Day6Assignment
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("welcome to logical programs");
                Console.WriteLine("Enter your choice ");
                Console.WriteLine(".............................................");
                Console.WriteLine("1 For: Fibonacci Series ");
                Console.WriteLine("2 For: Perfect Number ");
                Console.WriteLine("3 For: Prime Number ");
                Console.WriteLine("4 For: Reverse Number ");
                Console.WriteLine("5 For: Coupon  Number ");
                Console.WriteLine("6 For: Stopwatch  Number ");

            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //Fibonacco Series
                    UC1_FibonacciSeries FlibSeries = new UC1_FibonacciSeries();
                    FlibSeries.CheckFibonacciSeries();
                    break;
                case 2:
                    //Perfect Number
                    UC2_PerfectNumber PerfectNum = new UC2_PerfectNumber();
                    PerfectNum.CheckPerfectNumber();
                    break;
                case 3:
                    //Prime Number
                    UC3_PrimeNumber Primenumber = new UC3_PrimeNumber();
                    Primenumber.CheckPrimeNumber();
                    break;
                case 4:
                    //Reverese Number
                    UC4_ReverseOfNumber reverseNum = new UC4_ReverseOfNumber();
                    reverseNum.ReverseNumber();
                    break;
                case 5:
                    //Coupon Number
                    UC5_CouponNumber CouponNo = new UC5_CouponNumber();
                    CouponNo.Coupons();
                    break;
                case 6:
                    //Stop watch
                    UC6_StopWatch Stopwatches1 = new UC6_StopWatch();
                    Stopwatches1.stopwatches();
                    break;
                default:
                        Console.WriteLine("Invalid Selection. Select in b/w  1 to 4");
                        break;
                }
                Console.ReadLine();
            }
        }
    }

