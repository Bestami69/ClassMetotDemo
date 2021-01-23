using System;

namespace ClassMetodDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			musteri1.MusteriAdi = "Ali";
			musteri1.MusteriSoyadi = "O....Ş";
			musteri1.Yas = 24;
			musteri1.Meslek = "Esnaf";

			Musteri musteri2 = new Musteri();
			musteri2.MusteriAdi = "Sena";
			musteri2.MusteriSoyadi = "K.....İ";
			musteri2.Yas = 24;
			musteri2.Meslek = "Okul Öncesi Öğretmeni";

			Musteri musteri3 = new Musteri();
			musteri3.MusteriAdi = "Murat";
			musteri3.MusteriSoyadi = "Ç....K";
			musteri3.Yas = 28;
			musteri3.Meslek = "Çevre Mühendisi";


			Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

			foreach (Musteri musteri in musteriler)
			{
				Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
				Console.WriteLine(musteri.Yas);
				Console.WriteLine(musteri.Meslek);
			}

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);
			musteriManager.Ekle(musteri2);
			musteriManager.Ekle(musteri3);

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			musteriManager.Guncelle("Ali", "O....Ş");
			musteriManager.Guncelle("Sena", "K.....İ");
			musteriManager.Guncelle("Murat", "Ç....K");

			Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");

			musteriManager.Sil(musteri1);
			musteriManager.Sil(musteri2);
			musteriManager.Sil(musteri3);
		}
	}

}
