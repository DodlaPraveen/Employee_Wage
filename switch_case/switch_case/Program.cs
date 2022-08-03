using System;

namespace switch_case
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Fulltime = 2;
        public const int Emp_Rateperhr = 20;
        public const int Num_Working_Day = 20;
        public const int Max_Hrs_In_Month = 100;

        static void Main(string[] args)
        {
            int emphr = 0;
            int totalhrs = 0;
            int totalworkingdays = 0;

            while (totalhrs <= Max_Hrs_In_Month && totalworkingdays < Num_Working_Day)
            {
                totalworkingdays++;
                Random random = new Random();

                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        emphr = 4;
                        break;
                    case Is_Fulltime:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;
                }

                totalhrs += emphr;
                
                Console.WriteLine("Day# :" + totalworkingdays + "Emp hr :" + emphr);
            }
            int totalEmpwage = totalhrs * Emp_Rateperhr;
            Console.WriteLine("Total Emp Wag :" + totalEmpwage);
        }
    }
}
