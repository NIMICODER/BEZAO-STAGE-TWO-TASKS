using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year_program
{
    internal class Program
    {

    static void GetLeapYear()
        {
            int startYear, endYear;
            Console.WriteLine("enter starting year");
            startYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter ending year");
            endYear = Convert.ToInt32(Console.ReadLine());

            for (int i = startYear; i <= endYear; i++)
            {
                if ((i % 4)==0)
                {
                    Console.WriteLine($"Leap Year: {i}");
                }
            }
        }

        static void Main(string[] args)
        {
            GetLeapYear();
            Console.ReadLine();
        }
    }
}
