using ChallengePOO.Entities;

namespace ChallengePOO;

internal partial class Program
{
    private static List<Bird> _birds = new();
    private static List<Terrestrial> _terrestrials = new();

    private static void Main()
    {
        Menu();
    }
}