using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.MusteriAdi = "Emre Cevahir";
            musteri1.MusteriSoyadi = "Korkmaz";
            musteri1.Bakiye = 100;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 1;
            musteri2.MusteriAdi = "Çiko";
            musteri2.MusteriSoyadi = "Korkmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Liste(musteriler);

        }
    }
}
