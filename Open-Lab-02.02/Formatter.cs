using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            Console.Write(string.Format("{0:0.00} {1:0.00} {2:0.00} {3:0.00} {4:0.00}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]));
        }
    }
}
