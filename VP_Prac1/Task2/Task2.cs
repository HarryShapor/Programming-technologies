namespace Task2
{
    internal class Main2
    {
        public static double[] SumRow(double[,] matrix)
        {
            double[] sumRowMatrix = new double[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    count += matrix[i, j];
                }
                sumRowMatrix[i] = count;
            }

            return sumRowMatrix;
        }

        public static double[] ProductColumn(double[,] matrix)
        {
            double[] productColumnMatrix = new double[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double count = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    count *= matrix[j, i];
                }
                productColumnMatrix[i] = count;
            }

            return productColumnMatrix;
        }

        public static double MaxElemDiagon(double[,] matrix)
        {

            double maxElem = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && matrix[i, j] > maxElem)
                    {
                        maxElem = matrix[i, j];
                    }
                }
            }
            return maxElem;
        }
    }
}