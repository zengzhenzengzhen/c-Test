using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTest
{
    class Program
    {
        public static int m = 1;
        public static int s = 60;
        public static System.Timers.Timer timer = new System.Timers.Timer();
        static void Main(string[] args)
        {
            
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(djs);
            timer.Start();
            
            Console.ReadKey();
        }

        private static void djs(object source,ElapsedEventArgs e)
        {

            s--;
            if (s < 0)
            {
                s = 59;
                m--;
            }
            var min = m;
            var sec = s;
            if(m==0 && s==0)
            {
                timer.Stop();
            }
            Console.WriteLine(m + "分" + s + "秒");
        }
        
    }
}
