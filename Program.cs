using Microsoft.VisualBasic;
using System;
using TestePratico.ModalGR.CMD;

class Program
{
    static void Main()
    {

        Console.WriteLine(
            "Olá, meu nome é Julia e esta é minha resolução do desafio pratico da seleção para o Processo de Formação ModalGR 2023.\n" +
            "Qualquer duvida verifique o README, ou entre em contato comigo!");


        string saida;

        do
        {

            Console.WriteLine("Digite o número do exercício que deseja executar:");
            Console.WriteLine("1 - Contagem de letras");
            Console.WriteLine("2 - Valores repetidos em vetores");
            Console.WriteLine("3 - Separar dados numéricos de strings");

            string userInput = Console.ReadLine();
            int exercicio;

            if (int.TryParse(userInput, out exercicio))
            {
                switch (exercicio)
                {
                    case 1:
                        Console.Write("Digite a letra que deseja contar: ");
                        char letter = Console.ReadLine()![0];


                        Console.Write("Digite uma palavra/frase: ");
                        string? input = Console.ReadLine();


                        var (countLower, countUpper) = Exercicio1.CountLowerCase(input, letter);

                        Console.WriteLine($"Quantidade de letras '{letter}' minuscula(s): {countLower}");

                        Console.WriteLine($"Quantidade de letras '{letter}' maiuscula(s): {countUpper}");

                        break;

                    case 2:
                        Console.WriteLine("Digite os elementos do vetor A separados por vírgula:");
                        int[] a = ReadIntArray();

                        Console.WriteLine("Digite os elementos do vetor B separados por vírgula:");
                        int[] b = ReadIntArray();

                        int[] result = Exercicio2.FindRepeatedNumbers(a, b);

                        Console.WriteLine("Valores do terceiro vetor:");
                        foreach (int number in result)
                        {
                            Console.WriteLine(number);
                        }

                        break;

                    case 3:
                        Console.WriteLine("Digite os dados separados por vírgula:");
                        string? dados = Console.ReadLine();

                        var (strings, numeros) = Exercicio3.SeparateByComma(dados);

                        Console.WriteLine("Strings:");
                        foreach (string str in strings)
                        {
                            Console.WriteLine(str);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Números:");
                        foreach (double num in numeros)
                        {
                            Console.WriteLine(num);
                        }

                        break;
                    default:
                        Console.WriteLine("Exercício invalido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida");
            }

            Console.WriteLine(
                "\nDeseja continuar rodando os exercicios?(Digite 's' para sim, ou qualquer outra tecla para sair)");
            saida = Console.ReadLine().ToLower();

            if (saida == "s")
            {
                ClearConsole();
            }
            else
            {
                Console.WriteLine("\nFim do programa! Até mais!");
            }

        } while (saida == "s");
    }

static int[] ReadIntArray()
{
    string? input = Console.ReadLine();
    string[]? elements = input?.Split(',');

    int[] array = new int[elements.Length];

    for (int i = 0; i < elements.Length; i++)
    {
        if (int.TryParse(elements[i], out int number))
        {
            array[i] = number;
        }
        else
        {
            Console.WriteLine($"Valor inválido: {elements[i]}");
        }
    }

    return array;
}

static void ClearConsole()
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);
}

}