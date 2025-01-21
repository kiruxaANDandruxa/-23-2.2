using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyTaskClass22
    {
        private double _u;
        private double _y22;
        private double _x22;

        public MyTaskClass22(double u, double y22, double x22)
        {
            _u = u;
            _y22 = y22;
            _x22 = x22;
        }

        public void T()
        {
            Console.WriteLine($"T = {Math.Sin(2 * _u) + Math.Log(2 * Math.Pow(_y22, 2) + Math.Sqrt(_x22))}");
        }

    }
}
