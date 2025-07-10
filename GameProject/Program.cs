using GameProject;

internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new UserValidationManager());
        gamerManager.Add(new Gamer
        {
            Id = 1,
            FirstName = "ENGİN",
            Lastname = "DEMİROĞ",
            IdentityNumber = 12345,
            BirthYear = 1985
        });
    }
}