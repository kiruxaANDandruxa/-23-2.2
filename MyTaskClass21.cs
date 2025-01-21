using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass21
    {
        private double _e21;
        private double _h;
        private double _y21;

        public MyTaskClass21(double e21, double h, double y21)
        {
            _e21 = e21;
            _h = h;
            _y21 = y21;
        }

        public void P()
        {
            Console.WriteLine($"p = {Math.Pow(_e21, _y21 + 5.5) + 9.1 * Math.Pow(_h, 3)}");
        }

    }
}
