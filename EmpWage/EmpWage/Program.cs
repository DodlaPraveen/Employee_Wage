using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Fulltime = 1;
            int Emp_Rateperhr = 20;

            int emphr = 0;
            int empWage = 0;


            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == Is_Fulltime)
            {
                emphr = 8;
            }
            else
            {
                emphr = 0; 
            }
            empWage = emphr * Emp_Rateperhr;
            Console.WriteLine("Empwage :"+empWage);
        }
    }
}
