﻿using Microsoft.VisualBasic;
using Oop2;

internal class Program
{
    public static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Engin";
        musteri1.Soyadi = "Demiroğ";
        musteri1.TcNo = "12345678910";



        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.MusteriNo = "54321";
        musteri2.Id = 2;
        musteri2.SirketAdi = "Kodlama.io";  
        musteri2.VergiNo = "1234567890";


        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        CustomerManager musteriManager = new CustomerManager();
        musteriManager.Add(musteri1);
        musteriManager.Add(musteri2);

    }
}