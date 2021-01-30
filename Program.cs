using System;

namespace kendiçalışma
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği
            //Do not repeat yourself- KENDİNİ TEKRARLAMA

            string kategoriEtiketi = "Kategori";

            
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmısMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
