using ChallengePOO.Entities;
using ChallengePOO.Enums;

namespace ChallengePOO;

internal partial class Program
{
    private static void AddAnimalTerrestrial(string? name)
    {
        Console.WriteLine("Digite o número de patas");
        int numberOfPaws;
        string furColor = "", animalTerrestrialType;
        int.TryParse(Console.ReadLine(), out numberOfPaws);
        Console.WriteLine("O animal tem pelos? Digite '1' para sim, e '2' para não!");
        int haveFur;
        int.TryParse(Console.ReadLine(), out haveFur);
        if (haveFur.Equals(1))
        {
            Console.WriteLine("Digite a cor do pelo:");
            furColor = Console.ReadLine();
        }

        Console.WriteLine("Digite a cor do animal");
        var animalColor = Console.ReadLine();

        Console.WriteLine(
            $"Qual é o tipo de animal? Digite 1 para {AnimalTerrestrialType.Doméstico} e 2 para {AnimalTerrestrialType.Selvagem}");
        int isDomestic;
        int.TryParse(Console.ReadLine(), out isDomestic);

        animalTerrestrialType = isDomestic.Equals(1) ? "Domestico" : "Selvagem";

        if (haveFur.Equals(2)) furColor = animalColor;

        var terrestrial =
            new Terrestrial(name, numberOfPaws, furColor, animalColor, animalTerrestrialType);

        _terrestrials.Add(terrestrial);
    }
}