using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Paris", "Moskova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 269, 3579, 414, 50, 696366, 79666, 8669663, };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 269, 3579, 414, 50, 696366, 79666, 8669663, };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 269, 3579, 414, 50, 696366, 79666, 8669663, 10364};


            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5,8,12
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Galatasaray";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}












            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");

            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");


            ////Öğrenci isimlerini ve not ortalamarını saklayacak diziler

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult=0;

            //    //Her öğrenci içim 3 sınav notu girişi

            //    for(int j = 0; j<3 ; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinim {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult+=value; //Notları topluyoruz.
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult/3;

            //}

            ////Sınav ortalamaları 

            //for(int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}") ;

            //    //Öğrencilerin ortalaması ve geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı. Tembel!:)");
            //    }
            //    Console.WriteLine("------------------------------");
            //}




            #endregion

            Console.Read();
        }
    }
}
