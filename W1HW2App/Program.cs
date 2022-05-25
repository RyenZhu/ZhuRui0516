using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW2App
{
    class DayPrinter
    {
        static void Main(string[] args)
        {
            String[] day = new String[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(day[i]);
            }

        }

    }
}
