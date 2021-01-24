using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("---------------EKLE---------------");
            Console.WriteLine("Müşteri kaydedildi:" + musteri.MusteriAd);
            Console.WriteLine("---------------------------------");
        }

       
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("---------------SİL---------------");
            Console.WriteLine("Müşteri adı silindi:" + musteri.Id);
            Console.WriteLine("---------------------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("---------------LİSTELE---------------");
            Console.WriteLine("Listelendi.");
            Console.WriteLine("Id:" + musteri.Id);
            Console.WriteLine("Ad:" + musteri.MusteriAd);
            Console.WriteLine("Soyad:" + musteri.MusteriSoyad);
            Console.WriteLine("---------------------------------");
        }
        

    }
}
