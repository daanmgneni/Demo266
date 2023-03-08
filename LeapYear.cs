using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class LeapYear
    {
        public static void leap_year()
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year > 999 && year % 4 == 0) || (year % 400 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Its a leap year");
            }
            else
                Console.WriteLine("Not a leap year");
        }
    }
}
