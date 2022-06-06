using System;

namespace _01_Delege
{
    delegate void BenimDelegem (int sayi1,int sayi2);
    internal class Program
    {
        static void Main(string[] args)
        {
            BenimDelegem benimDelegem = new BenimDelegem(Topla);  //geriye void dönen 2 int parametresi alan fonksiyon yapmamız lazım , 
            benimDelegem += Carp;
            benimDelegem.Invoke(1, 2);
            Console.WriteLine("Hello World!");
        }

        static void Topla (int numara1,int numara2)
        {
            Console.WriteLine(numara1+numara2);
        }
        static void Carp(int sayi1, int sayi2) // delegeler sırasıyla  metodları tetikleyen yapılardır.
        {
            Console.WriteLine(sayi1*sayi2);
        }
    }
}
