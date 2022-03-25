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
                int num = Gen.Next(20, 60);
                numero[c] = num;

                if (minore > numero[c])
                {
                    minore = numero[c];
                }

            }
            for (int c = 0; c < dimensione; c++)
            {
                Console.WriteLine($"I Tempi sono: {numero[c]} secondi");
                
            }


            Console.WriteLine($"Il tempo più piccolo è:{minore}");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il primo giocatore e di {numero[0] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il secondo giocatore è di {numero[1] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il terzo giocatore è di {numero[2] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il quarto giocatore è di {numero[3] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il quinto giocatore è di {numero[4] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il sesto giocatore è di {numero[5] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il settimo giocatore è di {numero[6] - minore} secondi");
            Console.WriteLine($"Lo scarto del giocatore più veloce con il settimo giocatore è di {numero[7] - minore} secondi");
        }
    }
}

