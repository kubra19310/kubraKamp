using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            string urun1Adi = "Elma";
            double fiyati1 = 15;
            string aciklama = "Amasya Elması";

           

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-----------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,9);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80,8);



            Console.ReadLine();
        }
    }
  
}

//Dont repeat yourself - DRY 
