using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIO_Functions
{
    class PocketMamager
    {
        public  void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi :"+urun.Adi);
        }
            
        public void Ekle2(string urunadi,string aciklama,int fiyati,int stokadedi)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sepete Eklendi"+urunadi+aciklama+stokadedi);

        }
    }
}
