using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Emp = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Emp)
            {
                Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is Absent");
            }
        }
    }
}
