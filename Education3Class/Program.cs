internal class Program
{
    static void Main(string[] args)
    {
        kurs kurs1 = new kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlenmeOrani = 68;

        kurs kurs2 = new kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Barzan";
        kurs2.IzlenmeOrani = 50;

        kurs kurs3 = new kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOrani = 40;

        //Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

        kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

        foreach (var kurses in kurslar)
        {
            Console.WriteLine(kurses.KursAdi + ":" + kurses.Egitmen + " => " + kurses.IzlenmeOrani);
        }

    }



    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}