using System;
namespace ChallengePOO;

class Program
{
    static List<Bird> _birds = new List<Bird>();
    static List<Terrestrial> _terrestrials = new List<Terrestrial>();
    static void Main()
    {
        Menu();
    }
    static void AddNewAnimal()
    {
        Console.WriteLine("Digite o nome:");
        string name = Console.ReadLine();
        Console.WriteLine("Escola o tipo do Animal");
        Console.WriteLine($"1:{AnimalType.Terrestrial}");
        Console.WriteLine($"2:{AnimalType.Bird}");
        int choose;

        int.TryParse(Console.ReadLine(), out choose);
        switch (choose)
        {
            case 1:
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
                string animalColor = Console.ReadLine();

                Console.WriteLine("Qual é o tipo de animal? Digite 1 para Doméstico e 2 para selvagem");
                int isDomestic;
                int.TryParse(Console.ReadLine(), out isDomestic);

                animalTerrestrialType = (isDomestic.Equals(1)) ? "Domestico" : "Selvagem";

                if (haveFur.Equals(2))
                {
                    furColor = animalColor;
                }

                Terrestrial terrestrial =
                    new Terrestrial(name, numberOfPaws, furColor, animalColor, animalTerrestrialType);

                _terrestrials.Add(terrestrial);

                break;
            case 2:
                Console.WriteLine("Digite a cor da penas");
                string pityColor = Console.ReadLine();
                Bird bird = new Bird(name, pityColor);
                _birds.Add(bird);
                break;

            default:
                Console.WriteLine("Animal Default");
                break;
        }
    }
    static void Menu()
    {
        string nextStep;

        int choose;

        do
        {
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1: ADICIONAR ANIMAL");
            Console.WriteLine("2: IMPRIMIR ANIMAIS TERRESTRES");
            Console.WriteLine("3: IMPRIMIR AVES");
            Console.WriteLine("4: IMPRIMIR OS DOIS TIPOS");

            int.TryParse(Console.ReadLine(), out choose);

            switch (choose)
            {
                case 1:
                    AddNewAnimal();
                    break;
                case 2:
                    foreach (Terrestrial terrestrial in _terrestrials)
                    {
                        Console.WriteLine(terrestrial.ToString());
                        Console.WriteLine("---------------------");
                    }

                    Console.WriteLine($"Número de animais terrestres: {_terrestrials.Count}");

                    break;
                case 3:
                    foreach (Bird bird in _birds)
                    {
                        Console.WriteLine(bird.ToString());
                        Console.WriteLine("---------------------");
                    }

                    Console.WriteLine($"Número de aves: {_birds.Count}");
                    break;
                case 4:
                    Console.WriteLine("Terrestres");
                    foreach (Terrestrial terrestrial in _terrestrials)
                    {
                        Console.WriteLine(terrestrial.ToString());
                        Console.WriteLine("---------------------");
                    }

                    Console.WriteLine("Aves");
                    foreach (Bird bird in _birds)
                    {
                        Console.WriteLine(bird.ToString());
                        Console.WriteLine("---------------------");
                    }
                    break;


                default:
                    Console.Write("Opção invalida");
                    break;
            }

            Console.WriteLine("Deseja continuar? Digite S para continuar, e outra letra para sair");
            nextStep = Console.ReadLine().ToUpper();
        } while (nextStep == "S" || nextStep == "s");
    }
}