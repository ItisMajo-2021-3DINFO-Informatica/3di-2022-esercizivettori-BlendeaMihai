using System;

namespace BlendeaGolfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 80;
            int[] tiri = new int[dimensione];
            int min = int.MaxValue;
            int giocatoremigliore = 0;
            for(int c=0; c<dimensione; c++)
            {
                Console.WriteLine($"Dimmi quianti tiri complessivi ci ha messo il {c + 1}° giocatore per fare le 18 buche");
                tiri[c] = Convert.ToInt32(Console.ReadLine());
            }
            for (int c = 0; c < dimensione; c++)
            {
                if(min > tiri[c])
                {
                    min = tiri[c];
                    giocatoremigliore = c;
                }
            }
            Console.WriteLine($"Il giocatore migliore è il {giocatoremigliore+1}");
               
        }
    }
}
