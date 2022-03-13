using System;

namespace Pigreco
{
    class Program
    {
        public static int dimValue;
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi il numero di punti per lato:");
            dimValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Attendi...");
            double a = trovaPI(dimValue);
            Console.WriteLine(a);
            Console.ReadKey();

        }

        public static double trovaPI(int dim)
        {
            double puntoDiMezzoX = dim / 2;
            double puntoDiMezzoY = puntoDiMezzoX;
            double quadratoDiMezzo = puntoDiMezzoX * puntoDiMezzoX;

            double tot = 0;
            double intern = 0;

            for (double i = 0; i <= dim; i++)
            {
                for (double e = 0; e <= dim; e++)
                {
                    tot++;
                    double a = (i - puntoDiMezzoX) * (i - puntoDiMezzoX) + (e - puntoDiMezzoY) * (e - puntoDiMezzoY);
                    if (a <= quadratoDiMezzo)
                    {
                        intern++;
                    }
                }
            }

            double x = (intern / tot) * 4;
            return x;
        }
    }

    public class Vector2
    {
        public int x;
        public int y;
    }
}
