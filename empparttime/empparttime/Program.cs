using System;

namespace empparttime
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Part_Time = 1;
            int Is_Fulltime = 2;
            int Emp_Rateperhr = 20;

            int emphr = 0;
            int empWage = 0;


            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Part_Time)
            {
                emphr = 4;
            }
            else if (empCheck == Is_Fulltime)
            {
                emphr = 8;
            }
            else
            {
                emphr = 0;
            }
            empWage = emphr * Emp_Rateperhr;
            Console.WriteLine("Empwage :" + empWage);
        }
    }
}
