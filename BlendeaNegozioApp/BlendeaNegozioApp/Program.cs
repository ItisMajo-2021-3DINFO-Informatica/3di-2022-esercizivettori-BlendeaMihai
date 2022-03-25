using System;

namespace BlendeaNegozioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 2;
            decimal[] prodotti = new decimal[dimensione];
            decimal prezzoscontato = 0;
            for (int c = 0; c < dimensione; c++)
            {
                Console.WriteLine($"Il prezzo del {c} prodotto");
                prodotti[c] = Convert.ToDecimal(Console.ReadLine());
            }
            for (int c = 0; c < dimensione; c++)
            {
            prezzoscontato = prodotti[c]/100 * 78;
            Console.WriteLine($"Il prezzo scontato del {c} prodotto è {prezzoscontato}");
            }
            
        }
    }
}
