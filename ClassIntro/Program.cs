using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "hazal";
            int yas = 23;
            //kurs1 tipi Kurs
            //classların değişkenini oluşturmak ve değer atamak için 
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);
            //string[] kurslar = new string[] { }; bir öncekinde böyle tanımladık 
            //boyle sadece stringleri tutabiliriz
            //önce string tutuyorduk şimdi kurs objesi tutuyoruz.

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            }
            Console.WriteLine("Hello World!");
        }
    }
    //class tanımla
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
