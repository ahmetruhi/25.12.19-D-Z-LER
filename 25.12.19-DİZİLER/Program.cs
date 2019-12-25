using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._12._19_DİZİLER
{
    class Program
    {
        static void Main(string[] args)
        {

            //  //(Rastgele 100 sayıyıyı sıralama)
            //Random rnd = new Random();
            //int[] sayilar = new int[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    sayilar[i] = rnd.Next(100); //Rastgelere 100 sayı atama
            //}

            //Array.Sort(sayilar); //Sıralama

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    Console.WriteLine(sayilar[i]); //Ekrana yazdırma bütün sayıları
            //}





            //  //(Geometrik Yıldızlar)

            //for (int i = 1; i < 6; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            // (2 boyutlu 3x2'lik Matris)

            //int[,] dizi = new int[3, 2];

            //dizi[0, 0] = 50;
            //dizi[0, 1] = 25;
            //dizi[1, 0] = 45;
            //dizi[1, 1] = 56;
            //dizi[2, 0] = 21;
            //dizi[2, 1] = 23;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(dizi[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}




            //   //(Rastgele sayılarla 2 boyutlu 3x2'lik Matris)

            //Random rnd = new Random();
            //int[,] dizi = new int[3, 2];
            //for (int i = 0; i < dizi.GetLength(0); i++) //GetLength'teki 0 satırdır
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++) //GetLength'teki 1 sütundur
            //    {
            //        dizi[i, j] = rnd.Next(50);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(dizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            Console.WriteLine("Matris kaç satır olsun?:");
            byte satir = byte.Parse(Console.ReadLine());
            Console.WriteLine("Matris kaç sütun olsun?:");
            byte sutun = byte.Parse(Console.ReadLine());

            string[,] dizi = new string[satir, sutun];

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = (i + j) % 2 == 0 ? "*" : " ";
                    Console.Write(dizi[i,j]);
                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}
