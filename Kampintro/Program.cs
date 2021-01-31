using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety =tip güvenliği
            //kategoriEtiketi değer tutucu, takma isim,alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMİ = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (sistemeGirisYapmisMİ==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
