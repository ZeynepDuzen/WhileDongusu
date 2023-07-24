using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** While dongusu ile "merhaba" sözcüğünü 10 kez ekrana yazdıralım ; ***
            //int sayac = 1;

            //while (sayac <= 10)
            //{
            //    Console.WriteLine("Merhaba");
            //    sayac++;
            //}


            // *** while dongusu ile "Hosgeldiniz" sözcüğünü ekrana 5 kez yazdıralım ; *** 
            //int sayac = 1;

            //while (sayac <= 5)
            //{
            //    Console.WriteLine("Hosgeldiniz");
            //    sayac++;
            //}


            // *** while dongusu ile 1-10 arası sayıları listeleyelim ;
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}


            // *** while dongusu ile 1-5 arasi sayilarin toplamini hesaplayalım ; ***
            //int sayi = 1;
            //int toplam = 0;

            //while (sayi <= 5)
            //{
            //    toplam = toplam + sayi;
            //    sayi++;
            //}

            //Console.WriteLine(toplam);


            // *** Klavyeden girilen bir sayinin faktoriyel degerinin while dongusu kullanarak yazdiralim ; ***
            int faktoriyel = 1;
            int sayi;
            Console.WriteLine("Lutfen faktoriyelinin hesaplanmasini istediginiz bir sayi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());


            int i = 1;
            while (i <= sayi)
            {
                faktoriyel = faktoriyel * i;
                i++;
            }

            Console.WriteLine(faktoriyel);



            Console.Read();

        }
    }
}
