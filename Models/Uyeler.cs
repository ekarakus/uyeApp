using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uyeler.Models;

public static class Uyeler
    {
        public static List<Uye> liste = new List<Uye>();

        public static List<Uye> ListeDoldur()
        {
            liste.Add(new Uye()
            {
                Ad = "Efe",
                Soyad = "Karakütük",
                Email = "efekarakutuk@gmail.com",
                DogumYili = 2006
            });
            liste.Add(new Uye()
            {
                Ad = "Yağız",
                Soyad = "Akbal",
                Email = "yagizakbal@gmail.com",
                DogumYili = 2006
            });
            return liste;
        }
    }
