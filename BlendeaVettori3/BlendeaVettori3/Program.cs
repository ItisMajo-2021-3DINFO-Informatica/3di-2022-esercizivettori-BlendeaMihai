using System;

namespace BlendeaVettori3
{
    class Program
    {
        static void Main(string[] args)
        {
         const  int dimensione = 30;
            int[] numero = new int[dimensione];
            Random gen = new Random();
            int somma = 0;
            int media = 0;
            for (int c = 0; c < dimensione; c++)
            {
                int num=gen.Next(0, 50);
                numero[c] = num;
               somma = somma + numero[c];
                media = somma / dimensione;
               
            }
            Console.Write($"La media dei 30 valori inseriti è {media}");

        }
    }
}
