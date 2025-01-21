using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
public class MyTaskClass19
{
    private double _n19;
    private double _y19;
    private double _g19;

    public MyTaskClass19(double n19, double y19, double g19)
    {
        _n19 = n19;
        _y19 = y19;
        _g19 = g19;
    }

    public void P()
    {
        Console.WriteLine($"P = {_n19 * Math.Sqrt(Math.Pow(_y19, 3) + 1.09 * _g19)}");
    }

}
    
   