using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyTaskClass1
    {
        private double _t1;
        private double _l;

        public MyTaskClass1(double t1, double l)
        {
            _t1 = t1;
            _l = l;
        }

        public void R()
        {
            Console.WriteLine($"R = {3 * Math.Pow(_t1, 2) + 3 * Math.Pow(_l, 5) + 4.9}");
        }
    }
}
