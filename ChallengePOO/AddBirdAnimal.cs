using ChallengePOO.Entities;

namespace ChallengePOO;

internal partial class Program
{
    public static void AddBirdAnimal(string? name)
    {
        Console.WriteLine("Digite a cor da penas");
        var pityColor = Console.ReadLine();
        Bird bird = new Bird(name, pityColor);
        _birds.Add(bird);
    }
}