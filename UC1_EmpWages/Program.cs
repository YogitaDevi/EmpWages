using System;

namespace UC1_EmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
