using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class CoinFlip
    {
        public static void FlipCoin() 
        { int head = 0, tail = 0;
            Console.WriteLine("Enter the Flips");
            int no_of_flips = Convert.ToInt32(Console.ReadLine());
            if (no_of_flips>0)
            {
                for (int i=0;i<no_of_flips;i++)
                {
                    Random random = new Random();
                    int toss = random.Next(2);
                    Console.WriteLine("The coin is");
                    if (toss > 0)
                    {
                        Console.WriteLine("HEADS");
                        head++;
                    }
                    else
                    {
                        Console.WriteLine("TAILS");
                        tail++;
                    }
                }
                int head_percentage = head * 100 / no_of_flips;
                int tail_percentage = tail * 100 / no_of_flips;
                Console.WriteLine("the head percentage is : " + head_percentage);
                Console.WriteLine("the tail percentage is : " + tail_percentage);
            }

                
            


        
        }
    }
}
