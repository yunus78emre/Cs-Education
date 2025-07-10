using OOP3;

internal class Program
{
    static void Main(string[] args)
    {
        //İnterface'ler referans tiptir. Üst classı referans alıp aynı değeri tutabilir.
        ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
        ICreditManager vehicleCreditManager = new VehicleCreditManager();
        ICreditManager houseCreditManager = new HouseCreditManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(vehicleCreditManager,fileLoggerService);

        List<ICreditManager> krediler =new List<ICreditManager>() { ihtiyacCreditManager,houseCreditManager};

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}