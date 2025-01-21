using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyTaskClass4
    {
        private double _a;
        private double _t4;

        public MyTaskClass4(double a, double t3)
        {
            _a = a;
            _t4 = t3;
        }

        public void D()
        {
            Console.WriteLine($"D = {9.8 * Math.Pow(_a, 2) + 5.52 * Math.Cos(Math.Pow(_t4, 5))}");
        }
    }
}
