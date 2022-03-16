namespace ChallengePOO;

internal partial class Program
{
    public static void PrintTerrestrialAnimals()
    {
        foreach (var terrestrial in _terrestrials)
        {
            Console.WriteLine(terrestrial.ToString());
            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"Número de animais terrestres: {_terrestrials.Count}");
    }
}