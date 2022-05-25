using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("{0} year is a leap", year);

                }
                else
                    Console.WriteLine("{0} year is not a leap", year);
            }



        }
    }
}
