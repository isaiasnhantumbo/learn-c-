namespace ChallengePOO;

internal partial class Program
{
    private static void PrintBirdAnimals()
    {
        foreach (var bird in _birds)
        {
            Console.WriteLine(bird.ToString());
            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"Número de aves: {_birds.Count}");
    }
}