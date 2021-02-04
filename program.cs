using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ClassMethodDemo
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           MusteriManager Musteri = new MusteriManager();
           Musteri.Ekle();
           Musteri.Listele();
           Musteri.Silme();
           
        }
    }
}