﻿using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler =new MyList<string>();
        isimler.Add("Engin");

        Console.WriteLine(isimler.Length);

    }
}