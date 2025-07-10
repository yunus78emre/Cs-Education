using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<int> isimler =new MyList<int>();
        isimler.Add(15);
        isimler.Add(16);
        isimler.Add(16);

        Console.WriteLine(isimler.Length);
        for(int i = 0; i < isimler.Length; i++)
        {
            Console.WriteLine("index " + i + " is " + isimler[i]);
        }

    }
}