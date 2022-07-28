using System;

namespace switch_case
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Fulltime = 2;
        public const int Emp_Rateperhr = 20;
        static void Main(string[] args)
        {




            int emphr = 0;
            int empWage = 0;


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

            empWage = emphr * Emp_Rateperhr;
            Console.WriteLine("Empwage :" + empWage);
        }
    }
}
