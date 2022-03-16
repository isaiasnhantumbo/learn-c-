namespace ChallengePOO;

public class Terrestrial:Animal
{
    private int NumberOfPaws { set; get; }
    private string FurColor { set; get; }
    private string AnimalColor { set; get; }

    private string AnimalTerrestrialType { set; get; }

    public Terrestrial()
    {
        NumberOfPaws = 0;
        FurColor = "Default Color";
        AnimalColor = "Default Color";
        AnimalTerrestrialType = "Default Type";
    }
    public Terrestrial(string name, int numberOfPaws, string furColor, string animalColor,string animalTerrestrialType) : base(name)
    {
        NumberOfPaws = numberOfPaws;
        FurColor = furColor;
        AnimalColor = animalColor;
        AnimalTerrestrialType = animalTerrestrialType;
    }
    public string ToString()
    {
        return $"Nome: {Name}, Numero de patas: {NumberOfPaws}, Tipo: {AnimalTerrestrialType}, Cor de pele:{FurColor}, Cor do animal:{AnimalColor}";
    }
}