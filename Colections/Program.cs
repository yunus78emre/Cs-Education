﻿internal class Program
{
    public static void Main(string[] args)
    {
        List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem" , "Halil" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);

        isimler2.Add("Ali");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);

    }
}