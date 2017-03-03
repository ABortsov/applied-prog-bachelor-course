using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadLine() != "end")
            {
                double k = 0, b = 0;

                Console.WriteLine("Введите коэффициенты k и b для первой прямой");
                k = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Line LineA = new Line(k, b);

                Console.WriteLine("Введите коэффициенты k и b для второй прямой");
                k = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Line LineB = new Line(k, b);

                LineA.FindIntersection(LineB);
                Console.ReadKey();
            }
        }
    }
}
