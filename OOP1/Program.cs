using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UntPrice = 500;
        product1.UnitInStock = 3;


        Product product2 = new Product
        {
            Id = 2,
            CategoryId = 5,
            UnitInStock = 4,
            ProductName = "Kalem",
            UntPrice = 40
        };
        //pascalcase    //camelcase
        ProductManager productManager = new ProductManager();
                     //stack                   // heap
        productManager.Topla2(3,6);


    }
}