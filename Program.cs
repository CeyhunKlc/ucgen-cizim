using System;

namespace ucgencizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenar Uzunluğu:");
            int length = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int kenaruzunlugu = length;
            for (int i = 0; i < length; i++)
            {
                for (int j = kenaruzunlugu-1; j >0; j--)
                {
                    Console.Write(" ");
                }
                kenaruzunlugu--;
                for (int k = 1; k <= sayac; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                sayac++;
                
                Console.WriteLine();



            }
        }
    }
}