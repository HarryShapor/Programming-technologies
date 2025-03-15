namespace Task1
{
    internal class Main1
        {
        public static double ProcentLetter(Char letter, string stroka)
        {
            double count = 0, legth = stroka.Length;
            foreach (char c in stroka)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return Math.Round((count / legth) * 100, 2);
        }
    }
}