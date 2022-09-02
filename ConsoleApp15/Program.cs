using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StandardDeviation();
        }

        static void StandardDeviation()
        {
            int[] dataPoints = { 2, 3, 7, 5, 5, 1,-1, -3, 8, 5, 3, 4, 4, 6 };
            int particularNo = dataPoints[11];
            //find the total
            int total = 0;
            for (int i = 0; i < dataPoints.Length; i++)
            {
                if (dataPoints[i] < 0)
                {
                    continue;
                }
                total += dataPoints[i];
            }
            double average= total/dataPoints.Length; //get average

            double variance = 0;
            for (int x = 0; x < dataPoints.Length; x++)
            {
                variance += Math.Pow(dataPoints[x] - average, 2);
            }

            var standardDev= Math.Sqrt(variance/dataPoints.Length);
            Console.WriteLine($"the standard deviation is {standardDev}");
        }
    }
}
