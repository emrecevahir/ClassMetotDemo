using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kayıt İşleminiz Oluşturuldu. Sayın: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silme İşleminiz Gerçekleştirildi. Sayın: " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
        public void Liste(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi+" "+ musteri.Bakiye);
            }
        }
    }
}
