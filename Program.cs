using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(2,55,5);
            Time t2 = new Time(1,45,55);
            Time t3 = t1 + t2;
            Console.WriteLine(t1.getTime());
            Console.WriteLine(t2.getTime());
            Console.WriteLine(t3.getTime());
            Console.ReadKey();
        }
    }
}
