using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1="yazılım geliştirici kampı";
            string kurs2 = "proglamlamaya başlangıc temel kurs";
            string kurs3 = "java";
            
            //array-dizi
            string[] kurslar = new string[] { "yazılım geliştirici kampı",
                "proglamlamaya başlangıc temel kurs",
                "java","python"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //in kurslar ->kursları dolaş
            //kurs yerine ne yazsak çalışır buraya takma isim veriyoruz
            //foreach dizi temelli yapıları tek tek dönmeye yarıyor
            Console.WriteLine("for bitti");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
