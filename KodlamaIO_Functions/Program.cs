using System;

namespace KodlamaIO_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };
            //Type Safe
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");


            }
            Console.WriteLine("-----------------");

            PocketMamager Ekle = new PocketMamager();
            Ekle.Ekle(urun1);
            Ekle.Ekle(urun2);
        
            Ekle.Ekle2("Armut", "yESİL", 12,10);
            Ekle.Ekle2("Elma", "Kırmızı", 15,56);



            
          
        }
    }
}
//Do not repeat yourself-DRY-Clean Code-Best Practice
