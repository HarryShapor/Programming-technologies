namespace Figures
{
    public class RingFigure : CircleFigure
    {
        private double _radiusSmall;
        public double RadiusSmall
        {
            get
            {
                return _radiusSmall > 0 ? _radiusSmall : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                else if (value > Radius)
                {
                    throw new Exception("Значение меньше радиуса не может быть больше большего радиуса");
                }
                _radiusSmall = value;
            }
        }
        public RingFigure(string name, string color, double radius, double radiusSmall) : base(name, color, radius)
        {
            RadiusSmall = radiusSmall;
        }

        public override double CalcPerimeter()
        {
            Perimeter = Math.PI * 2 * (Radius + RadiusSmall);
            return Perimeter;
        }

        public override double CalcSquare()
        {
            Square = Math.PI * (Math.Pow(Radius, 2) - Math.Pow(RadiusSmall, 2));
            return Square;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
