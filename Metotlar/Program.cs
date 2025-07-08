using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Adi = "Elma";
        product1.Fiyat = 15;
        product1.Aciklama = "Amasya Elması";  
        
        Product product2 = new Product();
        product2.Adi = "Karpuz";   
        product2.Fiyat = 12;
        product2.Aciklama = "Diyarbakır Karpuzu";

        Product[] products = new Product[] { product1, product2 };

        foreach (var product in products)
        {
            Console.WriteLine("Ürün Adı: " + product.Adi);
            Console.WriteLine("Fiyatı: " + product.Fiyat);
            Console.WriteLine("Açıklama: " + product.Aciklama);
            Console.WriteLine("---------------------");
        }


        Console.WriteLine("----------Metotlar----------");

        //encapsulation
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(product1);
        sepetManager.Ekle(product2);

    }
}