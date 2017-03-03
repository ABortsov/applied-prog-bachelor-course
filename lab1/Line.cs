using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLine
{
    public class Line
    {
        private double _k = 0;
        private double _b = 0;
        public Line(double k, double b)
        {
            _k = k;
            _b = b;
        }
        public double GetK()
        {
            return _k;
        }
        public double GetB()
        {
            return _b;
        }
        public void FindIntersection(Line OtherLine)
        {
            if (_k == OtherLine.GetK())
            {
                if (_b != OtherLine.GetB())
                {
                    Console.WriteLine("Прямые не пересикаются.");
                }
                else
                {
                    Console.WriteLine("Прямые совпадают.");

                }
            }
            else
            {
                Console.WriteLine("Координаты пересечения x = " + FindX(OtherLine) + " y = " + FindY(OtherLine));

            }

        }
        public double FindX(Line OtherLine)
        {
            return (OtherLine.GetB() - _b) / (_k - OtherLine.GetK());
        }
        public double FindY(Line OtherLine)
        {
            return _k * (OtherLine.GetB() - _b) / (_k - OtherLine.GetK()) + _b;
        }
    }
}
