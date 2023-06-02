using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, meu nome é Julia e esta é minha resolução do desafio pratico da seleção para o Processo de Formação ModalGR 2023.\n" +
                          "Qualquer duvida verifique o README, ou entre em contato comigo!");
        Console.WriteLine("Digite o número do exercício que deseja executar:");
        Console.WriteLine("1 - Contagem de letras 'a'");
        Console.WriteLine("2 - Valores repetidos em vetores");
        Console.WriteLine("3 - Separar dados numéricos de strings");

        string userInput = Console.ReadLine();
        int exercicio;

        if (int.TryParse(userInput, out exercicio))
        {
            switch (exercicio)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                default:
                    Console.WriteLine("Exercício inválido");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida");
        }
    }

    static void Exercicio1()
    {
        // Implemente o código do exercício 1 aqui
    }

    static void Exercicio2()
    {
        // Implemente o código do exercício 2 aqui
    }

    static void Exercicio3()
    {
        // Implemente o código do exercício 3 aqui
    }
}