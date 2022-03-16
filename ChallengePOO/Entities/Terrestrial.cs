using ChallengePOO.Interfaces;

namespace ChallengePOO.Entities;

public class Terrestrial : Animal, IAnimal<Terrestrial>
{
    public Terrestrial()
    {
        NumberOfPaws = 0;
        FurColor = "Default Color";
        AnimalColor = "Default Color";
        AnimalTerrestrialType = "Default Type";
    }
    public Terrestrial(string name, int numberOfPaws, string furColor, string animalColor,
        string animalTerrestrialType) : base(name)
    {
        NumberOfPaws = numberOfPaws;
        FurColor = furColor;
        AnimalColor = animalColor;
        AnimalTerrestrialType = animalTerrestrialType;
    }

    private int NumberOfPaws { get; }
    private string FurColor { get; }
    private string AnimalColor { get; }
    private string AnimalTerrestrialType { get; }

    public string ToString()
    {
        return
            $"Nome: {Name}, Numero de patas: {NumberOfPaws}, Tipo: {AnimalTerrestrialType}, Cor de pele:{FurColor}, Cor do animal:{AnimalColor}";
    }
}