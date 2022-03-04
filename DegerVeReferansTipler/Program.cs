using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Value Type ----------");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? - sonuç 30 olur. (Değer tipli işlemlerde adres tutulmadığı için değere uzaktan erişilemez)
            Console.WriteLine("Sonuç =  {0}", sayi1);

            Console.WriteLine("---------- Referance Type ----------");

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]?? - sonuç 999 olur. array,class,interface gibi obje tipli yapılar bellekte adresleriyle tutulur ve
            //atamalar referans tipli bir veri ile yapılıyorsa değerin değişimine uzaktan erişim mümkündür.
            Console.WriteLine("Sonuç =  {0}", sayilar1[0]);
        }
    }
}
