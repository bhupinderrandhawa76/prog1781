using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itd_18008
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 15.5;
            double num2 = 16.5;
            double num3 = 17.5;
            double result = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average of "+num1+","+num2+" and "+num3+" is " + result);
        }
    }
}
