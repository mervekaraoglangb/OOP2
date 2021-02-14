using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //mervekaraoğlan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 01;
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "46204095640";
            musteri1.Adi = "Merve";
            musteri1.soyadi = "Karaoğlan";

            //kodlama.io girişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 02;
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "4465622";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);




        }
    }
}
