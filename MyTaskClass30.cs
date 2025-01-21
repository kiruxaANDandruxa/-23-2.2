using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass30
    {
        private double _e30;
        private double _y30;
        private double _r;

        public MyTaskClass30(double e30, double y30, double r)
        {
            _e30 = e30;
            _y30 = y30;
            _r = r;
        }

        public void W()
        {
            Console.WriteLine($"W = {Math.Pow(_e30, _y30 + _r) + 7.2 * Math.Sin(_r)}");
        }

    }
}
