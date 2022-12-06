using System;

namespace odev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

            try{ Hataya sebebiyet verme ihtimali olan kod }

            catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

            finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }*/

            try
            {
                Console.WriteLine("Bir Sayı Giriniz!");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz Sayi: "+ sayi);
                               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            try
            {
                int a = int.Parse("test");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş Değer");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                
                Console.WriteLine("Çok Büyük Yada Küçük Değer Girdiniz !");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandır :=) ");
            }
               
        }
    }
}