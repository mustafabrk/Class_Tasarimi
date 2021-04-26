using System;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolcu futbolcu = new Futbolcu()
            {
                Ad = "Mustafa Burak",
                Soyad = "Sert",
                Mevki = "Libero",
                Yas = 20,
                Takim = "Bilecik Belediyesi"
            };

            futbolcu.Ad = "Mustafa Burak ";
            futbolcu.Yas = 20;
            futbolcu.Mevki = "Libero";
            futbolcu.Takim = "Bilecik Belediyesi";
            Console.WriteLine(futbolcu.Bilgi());
            Console.ReadKey();

        }
    }
}
