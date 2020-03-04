using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mau ngitung luas atau keliling persegi panjang");
            Console.WriteLine("jika luas tekan 1");
            Console.WriteLine("jika keliling tekan 2");
            string hai = Console.ReadLine();
            if ( hai == "1")
            {
                luas();
            }
            else
            {
                keliling();
            }

         }
        public static void luas()
        {
            Console.WriteLine("masukan panjang");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("masukan lebar");
            int b = Convert.ToInt16(Console.ReadLine());


            int hasil = perkalian(a, b);

            Console.WriteLine("hasilnya adalah : " + hasil);
        }

        public static int perkalian(int x, int y)
        {
        int h = x * y;
        return h;
        }


        public static void keliling()
        {
            Console.WriteLine("masukan panjang");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("masukan lebar");
            int b = Convert.ToInt16(Console.ReadLine());

            int hasil = (a + b)*2;
            Console.WriteLine("hasilnya adalah " + hasil);
        }
    }
}
