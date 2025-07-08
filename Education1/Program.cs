
namespace Education1;
internal class Program
{
    private static void Main(string[] args)
    {
       String kategoriEtiketi = "Kategoriler";
       int ogrenciSayisi = 32000;
       double faizOrani = 0.075;   
       bool sistemeGirisYapildiMi = true;
       double dolarDun = 27.5; 
       double dolarBugun = 28.0;

        if(dolarBugun > dolarDun)
        {
            Console.WriteLine("Döviz yükseldi");
        }
        else if (dolarBugun < dolarDun)
        {
            Console.WriteLine("Döviz düştü");
        }
        else
        {
            Console.WriteLine("Döviz değişmedi");
        }   




        if (sistemeGirisYapildiMi == true)
       {
           Console.WriteLine("Kullanıcı ayarları butonu");
       }
       else
       {
           Console.WriteLine("Giriş yap butonu");
        }

    }
}