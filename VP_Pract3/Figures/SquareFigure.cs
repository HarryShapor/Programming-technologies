using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class SquareFigure : TheСorrectNgon
    {

        public SquareFigure(string name, string color, double lenght) :base(name,color, lenght, 4, lenght) { }

        public override double CalcPerimeter()
        {
            return base.CalcPerimeter();
        }

        public override double CalcSquare()
        {
            return base.CalcSquare();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
