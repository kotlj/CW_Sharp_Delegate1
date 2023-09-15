using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Sharp_Delegate1
{
    public delegate void Delegate(string message);
    public delegate void Delegate2(int f, int s);
    class StringForDelegate
    {
        public void toRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void toGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        public void toBlue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
        public void toStandart(string message)
        {
            Console.ResetColor();
            Console.WriteLine(message);
        }
    }
    class Numbers
    {
        public void sum(int f, int s)
        {
            Console.WriteLine(f + s);
        }
        public void subt(int f, int s)
        {
            Console.WriteLine(f - s);
        }
        public void mult(int f, int s)
        {
            Console.WriteLine(f * s);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StringForDelegate test = new StringForDelegate();
            Delegate deleg = test.toGreen;
            deleg += test.toRed;
            deleg += test.toBlue;
            deleg += test.toStandart;
            deleg("Testing");
            Numbers num = new Numbers();
            Delegate2 deleg2 = num.sum;
            deleg2 += num.subt;
            deleg2 += num.mult;
            deleg2(10, 2);
        }
    }
}
