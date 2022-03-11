using System;

namespace BlendeaVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            int[] numero = new int[dimensione];
            Random gen = new Random();

            for(int c=0; c<dimensione; c++)
            {
                int num = gen.Next(1, 100);
                numero[c] = num;
                Console.WriteLine($"num{c}="+numero[c]);
            }
            

        }
    }
}
