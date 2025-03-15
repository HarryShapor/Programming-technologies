using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class TriangleFigure : TheСorrectNgon
    {
        private double _height;

        public double Height
        {
            get
            {
                return _height > 0 ? _height : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _height = value;
            }
        }
        public TriangleFigure(string name, string color, double lenght) : base(name, color, lenght, 3) { }

        public TriangleFigure(string name, string color, double lenght, double height) : this(name, color, lenght)
        {
            this.Height = height;
        }

        public override double CalcPerimeter()
        {
            return base.CalcPerimeter();
        }

        public override double CalcSquare()
        {
            this.Square = 0.5 * this.Height * this.Lenght;
            return this.Square;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
