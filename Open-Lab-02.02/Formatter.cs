using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            for (int x = 0; x < numbers.GetLength(0); x++)
            {
                Console.Write(string.Format( "{0:0.00} ", numbers[x]));
            }
        }
    }
}
