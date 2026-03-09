using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcao = 0;

            Console.WriteLine("╔============================================================╗");
            Console.WriteLine("  Calculadora (Adicao / Subtracao / Multiplicacao / Divisao)");
            Console.WriteLine("╚============================================================╝");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Escolha uma opcao:");
                Console.WriteLine("1 - Adicao");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Sair");
                Console.WriteLine();

                Console.Write(">> ");
                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:
                        Console.Write("Digite o primeiro numero: ");
                        double Num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        double Num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Num1} + {Num2} = {Num1 + Num2}");
                        break;

                    case 2:
                        Console.Write("Digite o primeiro numero: ");
                        double Num3 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        double Num4 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Num3} - {Num4} = {Num3 - Num4}");
                        break;

                    case 3:
                        Console.Write("Digite o primeiro numero: ");
                        double Num5 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        double Num6 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Num5} * {Num6} = {Num5 * Num6}");
                        break;

                    case 4:
                        Console.Write("Digite o primeiro numero: ");
                        double Num7 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        double Num8 = double.Parse(Console.ReadLine());

                        if (Num8 == 0)
                        {
                            Console.WriteLine("Erro: Divisao por zero nao e permitida!");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {Num7} / {Num8} = {Num7 / Num8}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando a calculadora. Ate logo!");
                        break;

                    default:
                        Console.WriteLine("Opcao invalida! Escolha de 1 a 5.");
                        break;
                }

                Console.WriteLine();

            } while (Opcao != 5);
        }
    }
}
