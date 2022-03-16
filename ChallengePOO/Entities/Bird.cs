namespace ChallengePOO.Entities;
using ChallengePOO.Interfaces;

public class Bird : Animal, IAnimal<Bird>
{
    public Bird(string name, string pityColor) : base(name)
    {
        PityColor = pityColor;
    }

    private string PityColor { get; }

    public string ToString()
    {
        return $"Nome: {Name}, Cor das penas: {PityColor}";
    }
}