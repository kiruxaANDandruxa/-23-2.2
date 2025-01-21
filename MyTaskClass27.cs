using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass27
    {
        private double _v;
        private double _e27;
        private double _y27;
        private double _x27;

        public MyTaskClass27(double v, double e27, double y27, double x27)
        {
            _v = v;
            _e27 = e27;
            _y27 = y27;
            _x27 = x27;
        }

        public void W()
        {
            Console.WriteLine($"W = {1.03 * _v + Math.Pow(_e27, 2 * _y27) + Math.Tan(Math.Abs(_x27))}");
        }

    }
}
