using ChallengePOO.Enums;

namespace ChallengePOO;

internal partial class Program
{
    private static void AddNewAnimal()
    {
        Console.WriteLine("Digite o nome:");
        var name = Console.ReadLine();
        Console.WriteLine("Escola o tipo do Animal");
        Console.WriteLine($"1:{AnimalType.Terrestre}");
        Console.WriteLine($"2:{AnimalType.Ave}");
        int choose;
        int.TryParse(Console.ReadLine(), out choose);
        switch (choose)
        {
            case 1:
                AddAnimalTerrestrial(name);
                break;
            case 2:
                AddBirdAnimal(name);
                break;

            default:
                Console.WriteLine("Animal Default");
                break;
        }
    }
}