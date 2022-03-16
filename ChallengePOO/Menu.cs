namespace ChallengePOO;

internal partial class Program
{
    private static void Menu()
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
                    PrintTerrestrialAnimals();
                    break;
                case 3:
                    PrintBirdAnimals();
                    break;
                case 4:
                    Console.WriteLine("Terrestres");
                    PrintTerrestrialAnimals();

                    Console.WriteLine("Aves");
                    PrintBirdAnimals();
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