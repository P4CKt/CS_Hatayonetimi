﻿using System;

namespace odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

            try{ Hataya sebebiyet verme ihtimali olan kod }

            catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

            finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }*/
            
            Console.WriteLine("Bir Sayı Giriniz!");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Sayı: "+ sayi);
            Console.Read();


        }
    }
}