﻿using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------------------------------");
            }
            Console.WriteLine("---------------METOTLAR----------------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,8);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
        }
    }
}
