namespace Figures
{
    public class CircleFigure : Figure
    {
        private double _radius;
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

        protected CircleFigure(string name, string color) : base(name, color) { }
        public CircleFigure(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

        public override double CalcPerimeter()
        {
            this.Perimeter = 2 * Math.PI * Radius;
            return this.Perimeter;
        }

        public override double CalcSquare()
        {
            this.Square = Math.PI * Math.Pow(Radius, 2);
            return this.Square;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
