namespace Figures
{
    public abstract class Figure
    {
        protected string Name { get; set; }
        protected string Color { get; set; }
        protected double Perimeter;
        protected double Square;

        protected Figure(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public override string ToString()
        {
            return "Фигура " + Name + ", Цвет " + Color + ", Периметр " + Perimeter + ", Площадь " + Square;
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSquare();

    }
}
