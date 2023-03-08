using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class power_2
    {
        public static void power()
        {
            int num = 2;
            Console.WriteLine("Enter number n to print table of 2^n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n<31 )
            {
                for (int i = 0; i < n-2; i++) 
                {
                    Console.WriteLine( (2*i) );
                }
                
            }

        }
    }
}
