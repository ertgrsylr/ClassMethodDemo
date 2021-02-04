using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ClassMethodDemo
{

    public static class MusteriManager
    {
       
       Musteri Musteri = new Musteri();
       
       public void Ekle()
       {
       	Musteri.id = 1;
       	Musteri.ad = "Ekrem";
       	Musteri.soyad = "Daglı";
       	Musteri.cinsiyet = "Erkek";
       	Musteri.yas = 40;
       	Console.WriteLine("Id: "+ Musteri.id);
       	Console.WriteLine("Ad: "+ Musteri.ad);
       	Console.WriteLine("Soyad: "+ Musteri.soyad);
       	Console.WriteLine("Cinsiyet: "+ Musteri.cinsiyet);
       	Console.WriteLine("Yaş: "+ Musteri.yas);
       	Console.WriteLine("Müşteri&müşteriler eklendi.");
       	Console.WriteLine("--_------_------");
       }
       
       public void Listele();
       {
       	Musteri.id = 1;
       	Musteri.ad = "Ekrem";
       	Musteri.soyad = "Daglı";
       	Musteri.cinsiyet = "Erkek";
       	Musteri.yas = 40;
       	Console.WriteLine("Id: "+ Musteri.id);
       	Console.WriteLine("Ad: "+ Musteri.ad);
       	Console.WriteLine("Soyad: "+ Musteri.soyad);
       	Console.WriteLine("Cinsiyet: "+ Musteri.cinsiyet);
       	Console.WriteLine("Yaş: "+ Musteri.yas);
       	Console.WriteLine("Müşteri&müşteriler listelendi.");
       	Console.WriteLine("--_------_------");
       
       }
       
       public void Silme()
       {
       	Musteri.id = 1;
       	Musteri.ad = "Ekrem";
       	Musteri.soyad = "Daglı";
       	Musteri.cinsiyet = "Erkek";
       	Musteri.yas = 40;
       	Console.WriteLine("Id: "+ Musteri.id);
       	Console.WriteLine("Ad: "+ Musteri.ad);
       	Console.WriteLine("Soyad: "+ Musteri.soyad);
       	Console.WriteLine("Cinsiyet: "+ Musteri.cinsiyet);
       	Console.WriteLine("Yaş: "+ Musteri.yas);
       	Console.WriteLine("Müşteri&müşteriler siliniyor.");
       	Console.WriteLine("--_------_------");
       
       }
      
       
    }
}