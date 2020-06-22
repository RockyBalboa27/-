using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        public static double[] metod(double[] mas)
        {
            double sr = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sr += mas[i];
            }

            sr /= mas.Length;

            double max = -double.MaxValue, min = double.MaxValue;
            int maxind = 0, minind = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    maxind = i;
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                    minind = i;
                }
            }
            if (maxind > minind)
                for (int i = minind + 1; i < maxind; i++)
                    mas[i] = sr;
            else
                for (int i = maxind + 1; i < minind; i++)
                    mas[i] = sr;
            return mas;
        }
        static void Main(string[] args)
        {
            double[] mas = { 0.3, 1.7, 10.5, 5.5, 12.7 };

            for (int i = 0; i < mas.Length; i++)
                Console.Write("{0} ", mas[i]);
            Console.WriteLine();
            mas = metod(mas);
            for (int i = 0; i < mas.Length; i++)
                Console.Write("{0} ", mas[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
