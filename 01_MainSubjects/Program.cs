using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //string name;
            //name = "Emre";
            //Console.Write(name);
            #endregion

            #region String Değişkenler

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Emre";
            //customerSurname = "Esen";
            //customerPhone = "+90 530 123 23 23";
            //customerEmail = "emre@emreesen.com.tr";
            //district = "Pendik";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+  customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district+ "/" + city);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine();

            //customerName = "Mauro";
            //customerSurname = "İcardi";
            //customerPhone = "+90 0532 123 23";
            //customerEmail = "admin@galatasaray.org";
            //district = "Mamak";
            //city = "Ankara";

            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 23;
            //Console.WriteLine(number);

            int hamburgerPrice = 175;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 75;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice+ " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice+" TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata Fiyato: " + lemonadePrice + " TL");
            Console.WriteLine() ;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount; 
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;


            hamburgerCount = 4;
            cokeCount = 4;
            friesCount = 2;
            pizzaCount=0;
            lemonadeCount = 0;
            waterCount = 6;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice+ " TL");

            totalCokePrice  = cokeCount * cokePrice;


            Console.WriteLine("----------------------------------");

            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");

            totalWaterPrice = waterCount * waterPrice;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");

            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");

            totalLemonadePrice = lemonadeCount * lemonadePrice;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("----------------------------------");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice+ totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar" +" "+ totalPrice + " TL");



            #endregion











            Console.ReadLine();
        }
    }
}
