using System;

namespace BlendeaEsercizio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 8;
            int[] numero =new  int[dimensione];
            Random Gen = new Random();
            int minore = 150;
            int scarti = 0;
            for(int c = 0; c < dimensione; c++)
            {
                int num = Gen.Next(20, 120);
                numero[c] = num;

                if (minore > numero[c])
                {
                    minore = numero[c];
                }

            }
            for (int c = 0; c < dimensione; c++)
            {
                Console.WriteLine($"I Tempi sono: {numero[c]}");
                
            }


            Console.WriteLine($"Il tempo più piccolo è:{minore}");
            Console.WriteLine($"Gli scarti tra il tempo piu veloce e gli altri sono di({numero[0]},{numero[1]},{numero[2]},{numero[3]},{numero[4]},{numero[5]},{numero[6]},{numero[7]})");
        }
    }
}
