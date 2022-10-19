using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncLiveDemo
{
    public class Counter
    {
        public void Start()
        {
            Console.WriteLine("starting count up");
            CountUp();
            Console.WriteLine("starting count down");
            CountDown();
            Console.WriteLine("done");
        }
        public void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine(i);
            }
        }

        public void CountDown()
        {
            for (int i = 9; i >= 0; i--)
            {
                Thread.Sleep(200);
                Console.WriteLine(i);
            }
        }
    }
}
