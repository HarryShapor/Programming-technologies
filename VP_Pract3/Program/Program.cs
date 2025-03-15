using Figures;
namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CircleFigure circleFigure = new("Круг", "Красный", 15.2);
            Console.WriteLine(circleFigure.ToString());
            Console.WriteLine(circleFigure.CalcPerimeter());
            Console.WriteLine(circleFigure.CalcSquare());
            Console.WriteLine(circleFigure.ToString());
            Console.WriteLine();
            EllipseFigure ellipse = new("Эллипс", "Синий", 15.0, 32.3);
            Console.WriteLine(ellipse.ToString());
            Console.WriteLine(ellipse.CalcPerimeter());
            Console.WriteLine(ellipse.CalcSquare());
            Console.WriteLine(ellipse.ToString());
            Console.WriteLine();
            RingFigure ringFigure = new("Кольцо", "Золотое", 5, 3);
            Console.WriteLine(ringFigure.ToString());
            Console.WriteLine(ringFigure.CalcPerimeter());
            Console.WriteLine(ringFigure.CalcSquare());
            Console.WriteLine(ringFigure.ToString());
            Console.WriteLine();
            ParallelogramFigure parallelogramFigure = new("Параллелограмм", "Чёрный", 15.0, 2.3, 38.2, 9.3);
            Console.WriteLine(parallelogramFigure.ToString());
            Console.WriteLine(parallelogramFigure.CalcPerimeter());
            Console.WriteLine(parallelogramFigure.CalcSquare());
            Console.WriteLine(parallelogramFigure.ToString());
            Console.WriteLine();
            RectangleFigure rectangle = new("Прямоугольник", "Серый", 15.0, 2.3);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(rectangle.CalcPerimeter());
            Console.WriteLine(rectangle.CalcSquare());
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine();
            Rhomb rhomb = new("Ромб", "Фиолетовый", 15.0, 2.3, 18.0);
            Console.WriteLine(rhomb.ToString());
            Console.WriteLine(rhomb.CalcPerimeter());
            Console.WriteLine(rhomb.CalcSquare());
            Console.WriteLine(rhomb.ToString());
            Console.WriteLine();
            TheСorrectNgon theСorrectNgon = new("5-угольник", "Сереневенький", 7.9, 5, 13.0);
            Console.WriteLine(theСorrectNgon.ToString());
            Console.WriteLine(theСorrectNgon.CalcPerimeter());
            Console.WriteLine(theСorrectNgon.CalcSquare());
            Console.WriteLine(theСorrectNgon.ToString());
            Console.WriteLine();
            SquareFigure square = new("Квадрат", "Белый", 7.9);
            Console.WriteLine(square.ToString());
            Console.WriteLine(square.CalcPerimeter());
            Console.WriteLine(square.CalcSquare());
            Console.WriteLine(square.ToString());
            Console.WriteLine();
            TriangleFigure triangleFigure = new("Треугольник", "Лиловый", 10, 4);
            Console.WriteLine(triangleFigure.ToString());
            Console.WriteLine(triangleFigure.CalcPerimeter());
            Console.WriteLine(triangleFigure.CalcSquare());
            Console.WriteLine(triangleFigure.ToString());
        }
    }
}
