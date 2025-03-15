using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class TheСorrectNgon : Figure
    {
        private double _lenght;
        private int _n;
        private double _radius;
        public double Lenght
        {
            get
            {
                return _lenght > 0 ? _lenght : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _lenght = value;

            }
        }
        public int N
        {
            get
            {
                return _n > 0 ? _n : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _n = value;

            }
        }

        public double Radius
        {
            get
            {
                return _radius > 0 ? _radius : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _radius = value;

            }
        }

        public TheСorrectNgon(string name, string color, double lenght, int n) : base(name, color)
        {
            Lenght = lenght;
            N = n;
        }
        public TheСorrectNgon(string name, string color, double lenght, int n, double radius)
            : this(name, color, lenght, n)
        {
            Radius = radius;
        }


        public override double CalcPerimeter()
        {
            this.Perimeter = Lenght * N;
            return this.Perimeter;
        }

        public override double CalcSquare()
        {
            this.Square = 0.5 * CalcPerimeter() * Radius;
            return this.Square;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
