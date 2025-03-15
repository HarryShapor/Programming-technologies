namespace Figures
{
    public class RectangleFigure : ParallelogramFigure
    {

        public RectangleFigure(string name, string color, double lenghtA, double lenghtB) : base(name, color, lenghtA, lenghtB)
        {
        }

        public override double CalcPerimeter()
        {
            Perimeter = 2 * (LenghtA + LenghtB);
            return Perimeter;
        }

        public override double CalcSquare()
        {
            Square = LenghtA * LenghtB;
            return Square;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
