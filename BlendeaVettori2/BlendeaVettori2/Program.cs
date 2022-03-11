using System;

namespace BlendeaVettori2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            int[] numero = new int[dimensione];
            Random Gen = new Random();
            int maggiori = 0;
            for(int c=0;c<dimensione; c++)
            {
                int num = Gen.Next(1, 100);
                numero[c] = num;
            
            if( num > 50)
                {

                    maggiori = num;

                }
            }
            Console.Write($"I numeri maggiori di 50 sono= {maggiori}");
        }
    }
}
