using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass20
    {
        private double _e20;
        private double _k;
        private double _x20;
        private double _y20;

        public MyTaskClass20(double e20, double k, double x20, double y20)
        {
            _e20 = e20;
            _k = k;
            _x20 = x20;
            _y20 = y20;
        }

        public void U()
        {
            Console.WriteLine($"U = {Math.Pow(_e20, _k + _y20) + Math.Tan(_x20) * Math.Sqrt(_y20)}");
        }

    }
}
