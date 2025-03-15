namespace Figures
{
    public class ParallelogramFigure : Figure
    {
        private double _lenghtA;
        private double _lenghtB;
        private double _heightA;
        private double _heightB;
        public double LenghtA
        {
            get
            {
                return _lenghtA > 0 ? _lenghtA : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _lenghtA = value;
            }
        }
        public double LenghtB
        {
            get
            {
                return _lenghtB > 0 ? _lenghtB : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _lenghtB = value;
            }
        }
        public double HeightA
        {
            get
            {
                return _heightA > 0 ? _heightA : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _heightA = value;
            }
        }
        public double HeightB
        {
            get
            {
                return _heightB > 0 ? _heightB : throw new Exception("Значение не установлено");
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Значение меньше нуля");
                }
                _heightB = value;
            }
        }
        protected ParallelogramFigure(string name, string color) : base(name, color) { }
        protected ParallelogramFigure(string name, string color, double lenght) : base(name, color)
        {
            LenghtA = lenght;
        }
        public ParallelogramFigure(string name, string color, double lenghtA, double lenghtB) : base(name, color)
        {
            LenghtA = lenghtA;
            LenghtB = lenghtB;
        }

        public ParallelogramFigure(string name, string color, double lenght, double height, bool B)
            : base(name, color)
        {
            if (B == true)
            {
                LenghtB = lenght;
                HeightB = height;
            }
            else
            {
                LenghtA = lenght;
                HeightA = height;
            }
        }

        public ParallelogramFigure(string name, string color, double lenghtA, double lenghtB,
            double heightA, double heightB) : this(name, color, lenghtA, heightA, false)
        {
            LenghtB = lenghtB;
            HeightB = heightB;
        }

        public override double CalcPerimeter()
        {
            this.Perimeter = 2 * LenghtA + 2 * LenghtB;
            return this.Perimeter;
        }

        public override double CalcSquare()
        {
            if (LenghtA > 0 & HeightA > 0)
            {
                this.Square = LenghtA * HeightA;
            }
            else
            {
                this.Square = LenghtB * HeightB;
            }
            return this.Square;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
