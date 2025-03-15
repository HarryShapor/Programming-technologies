using Task1;
using Task2;

namespace UserUI
{
    public class Program
    {

        static void Main(String[] args)
        {
            string stroka = "Табачкова и Шапоренко, бригада 1";
            Char c = 'а';
            Console.WriteLine("Процент символов 'а' в строке '" + stroka
                + "' = " + Main1.ProcentLetter(c, stroka) + "%");

            double[,] matrix = new double[10, 10] {
                {-12.34, 67.89, 45.67, -23.45, 56.78, -90.12,34.56, 22.33, 11.22, -78.91},
                {-55.44, 88.77, -66.55, 33.44, -77.88, 12.34, -45.67, 32.10, -88.99, 54.32},
                {-23.45, 67.89, 11.22, -90.12, 56.78, 34.56, -78.91, 45.67, -12.34, 22.33 },
                {-55.44, 33.44, 88.77, -66.55, 54.32, -77.88, 32.10, 12.34, -88.99, -45.67 },
                {67.89, -23.45, 56.78, -78.91, 11.22, 34.56, -55.44, 45.67, -90.12, 22.33 },
                {88.77, -66.55, 33.44, 54.32, 32.10, -45.67, -77.88, 12.34, -88.99, 67.89 },
                {-23.45, 56.78, 34.56, 45.67, 22.33, 11.22, -90.12, 88.77, -55.44, -78.91},
                {-66.55, 54.32, 33.44, -77.88, 12.34, -88.99, 32.10, -45.67, 67.89, 56.78},
                {-23.45, 45.67, 22.33, 34.56, -90.12, 11.22, 88.77, -78.91, 33.44, -66.55},
                {-55.44, 54.32, -77.88, 12.34, -88.99, 32.10, -23.45, 56.78, 67.89, -45.67}};
            Console.WriteLine("\t\t\t\tМатрица");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            double[] matrixSumRow = Main2.SumRow(matrix);
            for (int i = 0; i < matrixSumRow.Length; i++)
            {
                Console.WriteLine("Сумма чисел в строке " + (i + 1) + " = " +
                    Math.Round(matrixSumRow[i], 2));
            }
            double[] matrixProductColumn = Main2.ProductColumn(matrix);
            for (int i = 0; i < matrixProductColumn.Length; i++)
            {
                Console.WriteLine("Произведение чисел в столбце " + (i + 1) + " = " +
                    Math.Round(matrixProductColumn[i], 2));
            }

            Console.WriteLine("Максимальное число на диагонали = " + Main2.MaxElemDiagon(matrix));

        }
    }
}