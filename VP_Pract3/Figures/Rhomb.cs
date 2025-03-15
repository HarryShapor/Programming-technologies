using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rhomb : ParallelogramFigure
    {
        private double _bigDiagonal;
        private double _smallDiagonal;

        public double BigDiagonal
        {
            get
            {
                return _bigDiagonal > 0 ? _bigDiagonal : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _bigDiagonal = value;
            }
        }
        public double SmallDiagonal
        {
            get
            {
                return _smallDiagonal > 0 ? _smallDiagonal : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _smallDiagonal = value;
            }
        }
        public Rhomb(string name, string color, double length) : base(name, color, length)
        {
        }

        public Rhomb(string name, string color, double bigDiagonal, double smallDiagonal) : base(name, color)
        {
            SmallDiagonal = smallDiagonal;
            BigDiagonal = bigDiagonal;
        }
        public Rhomb(string name, string color, double length, double bigDiagonal, double smallDiagonal) :
            this(name, color, bigDiagonal, smallDiagonal)
        {
            LenghtA = length;
        }
        public override double CalcPerimeter()
        {
            Perimeter = 4 * LenghtA;
            return Perimeter;
        }

        public override double CalcSquare()
        {
            Square = 0.5 * BigDiagonal * SmallDiagonal;
            return Square;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
