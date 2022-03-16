namespace ChallengePOO;

public class Bird:Animal
{
    private string PityColor { set; get; }

    public Bird(string name, string pityColor) : base(name)
    {
        PityColor = pityColor;
    }
    public string ToString()
    {
        return $"Nome: {Name}, Cor das penas: {PityColor}";
    }
}