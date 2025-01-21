using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass25
    {
        private double _e25;
        private double _y25;
        private double _f25;

        public MyTaskClass25(double e25, double y25, double f25)
        {
            _e25 = e25;
            _y25 = y25;
            _f25 = f25;
        }

        public void G()
        {
            Console.WriteLine($"U = {Math.Pow(_e25, 2 * _y25) + Math.Sin(_f25)}");
        }

    }
}
