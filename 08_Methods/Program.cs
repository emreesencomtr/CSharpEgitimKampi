using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Emre Esen");
            //    Console.WriteLine("Merve Esen");
            //    Console.WriteLine("Mauro İcardi");
            //    Console.WriteLine("Fernando Muslera");

            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //            void Sum()
            //            {
            //                int x = 1;
            //                int y=2;
            //                int z = x + y;
            //                Console.WriteLine(z);

            //;           }

            //            Sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)

            //{
            //    Console.WriteLine(customerName);


            //}

            //WriteMethod("Emre Esen");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name+" "+surName);
            //}

            //CustomerCard("Emre", "Esen");
            //CustomerCard("Mauro", "İcardi");
            //CustomerCard("Fernando", "Muslera");



            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int  number1, int number2, int number3)
            //{
            //    int result = number1 + number2+number2;
            //    Console.WriteLine(result);
            //}

            //Sum(25, 45, 35);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Emre Esen";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Emre";
            //    string surName = "Esen";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());




            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            // string CountryCard(string countrName, string capital, string flagColor)
            // {
            //     string cardInfo = "Ülke: " +countrName+ " - Başkent: "+capital+" - Bayrak Rengi: "+flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;

            // Console.Write("Ülke Adını Giriniz:");
            // x=Console.ReadLine();
            // Console.WriteLine();
            // Console.Write("Başkenti Giriniz:");
            // y=Console.ReadLine();
            // Console.WriteLine();
            // Console.Write("Bayrak Rengini Giriniz: ");
            // z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Ukrayna","Kiev","Sarı - Mavi"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result= number1+number2;
            //    return result;
            //}


            //Console.WriteLine(Sum(23,23));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1+exam2 + exam3)/3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçti" + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return  student +" İsimli Öğrenci Başarısız Oldu!"+ "Ortalama: " +result;
            //    }

               

            //}
            //Console.WriteLine(ExamResult("Emre", 85, 12, 36));
            //Console.WriteLine(ExamResult("Elif", 45, 56, 41));
            //Console.WriteLine(ExamResult("Zeynep", 66, 45, 85));
            //Console.WriteLine(ExamResult("Ahmet", 86, 75, 88));

            #endregion





            Console.Read();
        }
    }
}
