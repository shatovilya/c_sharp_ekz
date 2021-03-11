using System;
using System.IO;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double b,x,y,xo,xk,dx;
            xo=-2.05;
            xk=-3.05;
            dx=-0.2;
            b = 3.4;


            Console.WriteLine(" Результаты расчета");
            for (x = xo; x >= xk+dx; x += dx) //Заголовок
            {
                y = x* Math.Sin(Math.Sqrt(x+b-0.0084));
                Console.WriteLine(" x= " + x + '\t' + " y= " + y);
            }
            Console.ReadLine();
        }
    }
}
