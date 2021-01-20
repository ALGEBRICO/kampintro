using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            Product ürün = new Product();

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Kerem varışşğ";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Payhtın";
            kurs3.Egitmen = "Berkay bilgin";
            kurs3.IzlenmeOrani = 95;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "JVAA";
            kurs4.Egitmen = "Murattutran";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " : " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +  " : " + kurs.Egitmen);
            }
            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; } //prop yazıp çift tab ile bu public satırı açılmakta

        public string Egitmen{ get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
