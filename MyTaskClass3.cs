using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyTaskClass3
    {
        private double _n;
        private double _y3;

        public MyTaskClass3(double n, double y3)
        {
            _n = n;
            _y3 = y3;
        }

        public void K()
        {
            Console.WriteLine($"K = {_n * (_y3 + 3.5) + Math.Sqrt(_y3)}");
        }
    }
}
