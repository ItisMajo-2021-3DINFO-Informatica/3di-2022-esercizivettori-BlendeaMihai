using System;

namespace BlendeaVettori5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione= 1000;
            Random Gen = new Random();
            int[] numero = new int[dimensione];
            int min = 0;
            int i = 0;
            double media1 = 0;
            double media2 = 0;
            for(int c=0; c< dimensione; c++)
            {
                int num = Gen.Next(1, 250);
                numero[c] = num;
              if(numero[c] <= 175)
                {
                    i++;
                    media1 = i * 100;
                    media2 = media1 / dimensione;
                }

            }
            Console.WriteLine($"I numeri minori di 175 sono :{i} ");
            Console.WriteLine($"La media dei numeri minori di 175 è :{media2} ");




        }
    }
}
