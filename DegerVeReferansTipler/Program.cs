﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int sayi1 = 10;
        int sayi2 = 20;
        sayi1 = sayi2;
        sayi2 = 65;
        //sayi1=30


        //int,decimal,float,double,bool => deger tip  > in stack
        //array,class,interface => referans tip=>in heap
        int[] sayilar1 = new int[] {10,20,30};
        int[] sayilar2 = new int[] { 10, 20, 30 };
        sayilar1 = sayilar2;
        sayilar2[0] = 998;
        
    }
}