namespace Figures
{
    public class EllipseFigure : CircleFigure
    {
        private double _half_axisA;
        private double _half_axisB;
        public double Half_axisA
        {
            get
            {
                return _half_axisA > 0 ? _half_axisA : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _half_axisA = value;
            }
        }
        public double Half_axisB
        {
            get
            {
                return _half_axisB > 0 ? _half_axisB : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _half_axisB = value;
            }
        }
        public EllipseFigure(string name, string color, double half_axisA, double half_axisB) : base(name, color)
        {
            Half_axisB = half_axisB;
            Half_axisA = half_axisA;
        }

        public override double CalcPerimeter()
        {
            Perimeter = 2 * Math.PI + Math.Sqrt((Math.Pow(Half_axisA, 2) + Math.Pow(Half_axisB, 2)) / 2);
            return Perimeter;
        }

        public override double CalcSquare()
        {
            Square = Math.PI * Half_axisA * Half_axisB;
            return Square;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
