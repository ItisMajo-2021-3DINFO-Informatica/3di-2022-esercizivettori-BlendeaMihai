using System;

namespace BlendeaVettori4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione = 100;
            int[] numero = new int[dimensione];
            Random Gen = new Random();
            int max = 0;
            int min = 5000;
            for (int c = 0; c < dimensione; c++)
            {
                int num = Gen.Next(1000, 3000);
                numero[c] = num;
              if(max < numero[c])
                {
                    max = numero[c];
                }

              else if( min > numero[c])
                {
                    min = numero[c];
                }

            }
            Console.WriteLine($"Il numero piu grande è: {max}");
            Console.WriteLine($"Il numero piu piccolo è: {min}");
        }
    }
}
