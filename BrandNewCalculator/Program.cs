namespace BrandNewCalculator //Atendendo os requisitos do exercício proposto. (Nada contra o flamemgo).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] historico = new string[10];
            int operacoesH = 0;
            decimal number1, number2, numberFinal;
            int escolha;
            bool ehVerdade = true;
            do
            {
                if (operacoesH == 10)
                {
                    operacoesH = 0;
                }

                Console.Clear();
                Console.WriteLine("Brand New Calculator - 2023 ");
                Console.WriteLine("--- Escolha a operação desejada -- ");
                Console.WriteLine("1 - Adição.");
                Console.WriteLine("2 - Subtração.");
                Console.WriteLine("3 - Multiplicação.");
                Console.WriteLine("4 - Divisão.");
                Console.WriteLine("5 - Tabuada.");
                Console.WriteLine("6 - Mostrar histórico de operações.");
                Console.WriteLine("7 - Finalizar");
                Console.WriteLine();

                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        number1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        number2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n");
                        numberFinal = number1 + number2;
                        Console.WriteLine("O resultado é " + number1 + " + " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " + " + number2 + " = " + numberFinal;

                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        number1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        number2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n");
                        numberFinal = number1 - number2;
                        Console.WriteLine("O resultado é " + number1 + " - " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " - " + number2 + " = " + numberFinal;
                        break;
                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        number1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        number2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n");
                        numberFinal = number1 * number2;
                        Console.WriteLine("O resultado é " + number1 + " * " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " * " + number2 + " = " + numberFinal;

                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        number1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        number2 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (number2 == 0)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Esse número é inválido! Escreva novamente o segundo número: ");
                            number2 = Convert.ToDecimal(Console.ReadLine());
                        }
                        numberFinal = number1 / number2;
                        Console.WriteLine("O resultado é " + number1 + " / " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " / " + number2 + " = " + numberFinal;
                        break;

                    case 5:
                        Console.WriteLine("Digite um número para fazer a tabuada: ");
                        int numberT = Convert.ToInt32(Console.ReadLine());
                        int numberFt;
                        for (int i = 0; i <= 10; i++)
                        {
                            numberFt = numberT * i;
                            Console.WriteLine(numberT + " x " + i + " = " + numberFt);
                        }
                        break;

                    case 6:
                        for (int i = 0; i < historico.Length; i++)
                        {
                            if (historico[i] != null)
                            {
                                Console.WriteLine(historico[i]);

                            }
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("\n");
                        Console.WriteLine("Obrigado por usar a calculadora!");
                        ehVerdade = false;
                        break;

                    default:
                        Console.WriteLine("Essa opção é inválida! Digite novamente!");
                        break;

                }
                operacoesH++;
                Console.ReadLine();
            } while (ehVerdade == true);
        }
    }
}