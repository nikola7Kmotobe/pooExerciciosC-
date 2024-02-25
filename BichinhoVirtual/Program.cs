using BichinhoVirtual;
using static System.Net.Mime.MediaTypeNames;

int cont = 0;
try
{
    Console.Write("Crie o seu novo Bichinho \n Insira o nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Insira a classe: ");
    string classe = Console.ReadLine()!;

    Console.Write("Insira a familia: ");
    string familia = Console.ReadLine()!;

    Bichinho b1 = new Bichinho(nome, classe, familia);
    Console.WriteLine(b1.Nasceu());

    while (cont != 4)
    {
        Console.WriteLine("O que o " + b1.Nome + " vai fazer agora ? " + "\n1 - Comer \n2 - Correr \n3 - Dormir \n4 - Morrer");
        cont = int.Parse(Console.ReadLine()!);
        if (cont > 0 || cont < 5)
        {
            switch (cont)
            {
                case 1:
                    Console.WriteLine(b1.Comeu());
                    break;
                case 2:
                    Console.WriteLine(b1.Correr());
                    break;
                case 3:
                    Console.WriteLine(b1.Dormir());
                    break;
                case 4:
                    Console.WriteLine(b1.Morreu());
                    break;
            }

        }
        else
        {
            Console.WriteLine("Opção inválida, tente novamente");
        }
    }
    Console.WriteLine("Fim do nosso ciclo, Amigão!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}