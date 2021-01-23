using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adem Uras
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Adem";
            musteri1.Soyadi = "Uras";
            musteri1.TcNo = "11111111111";

            //URAS LTD A.Ş.
            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "URAS LTD. A.Ş.";
            musteri2.VergiNo = "2222222222";

            //Gerçek Müşteri-Tüzel Müşteri

            Musteri musteri3=new GercekMusteri();
            Musteri musteri4=new TuzelMusteri();

            MusteriManager musteriManager=new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
