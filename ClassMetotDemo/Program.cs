using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri mus1 = new Musteri();
            mus1.Id = 1;
            mus1.MusteriAd = "Mırmır";
            mus1.MusteriSoyad = "Kedi";

            Musteri mus2 = new Musteri();
            mus2.Id = 2;
            mus2.MusteriAd = "Şeftali";
            mus2.MusteriSoyad = "Kedi";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(mus1);
            musteriManager.Ekle(mus2);

            musteriManager.Listele(mus1);
            musteriManager.Listele(mus2);

            musteriManager.Sil(mus1);
            musteriManager.Sil(mus2);


        }
    }
}
