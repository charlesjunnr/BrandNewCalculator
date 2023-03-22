namespace BrandNewCalculator //Atendendo os requisitos do exercício proposto. (Nada contra o flamemgo).
{
    internal class Program
    {
        static int MostrarMenu()
        {
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
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return escolha; // rertorna o valor da variável. É necessário criar uma variável no método Main para receber esse valor. 
        }
        static void MensagemInvalida(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();

        } // REUTILIZAÇÃO DO CÓDIGO NA MAIN
        static void GerarTabuada() // NOMES DE FUNÇÕES SEMPRE COMEÇAM COM LETRA MAIÚSCULA;
        {
            Console.WriteLine("Digite um número para fazer a tabuada: ");
            int numberT = Convert.ToInt32(Console.ReadLine());
            int numberFt;
            for (int i = 0; i <= 10; i++)
            {
                int resto = i % 2;
                if (resto == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                numberFt = numberT * i;
                Console.WriteLine(numberT + " x " + i + " = " + numberFt);
                Console.ResetColor();
                
            }
            Console.ReadLine();
        }
        static void VisualizarOperacoesRealizadas(string[] historico) // No método MAIN foi criada uma variável desse tipo e foi passada por parâmetro.
        {
            for (int i = 0; i < historico.Length; i++)
            {
                if (historico[i] != null)
                {
                    Console.WriteLine(historico[i]);

                }
            }
            Console.ReadLine();
        }
        static decimal ObterValorDecimal(string mensagem)
        {
            Console.WriteLine(mensagem);
            decimal numero = Convert.ToDecimal(Console.ReadLine());
            return numero;
        }
        static void Main(string[] args) //Funções tipo VOID não retornam valores. 
        {
            string[] historico = new string[100];
            int operacoesH = 0;
            decimal number1, number2, numberFinal;
            bool ehVerdade = true;
            do
            {
                if (operacoesH == 100)
                {
                    operacoesH = 0;
                }

                int escolha = MostrarMenu(); // Variável criada para receber o valor da variável criada no Menu. 

                if(escolha == 5)
                {
                    GerarTabuada();
                    continue;
                }else if (escolha == 6)
                {
                    VisualizarOperacoesRealizadas(historico);
                    continue;
                }else if(escolha == 7)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Obrigado por usar a calculadora!");
                    ehVerdade = false;
                }else if(
                    escolha != 1 &&
                    escolha != 2 &&
                    escolha != 3 &&
                    escolha != 4 &&
                    escolha != 5 &&
                    escolha != 6 &&
                    escolha != 7)
                {
                    MensagemInvalida("Opção não encontrada no menu! Digite novamente!");
                    Console.ReadLine();
                    continue;
                }
                number1 = ObterValorDecimal("Digite o valor do primeiro número: ");
                number2 = ObterValorDecimal("Digite o valor do segundo número: ");

                switch (escolha)
                {
                    case 1:
                        numberFinal = number1 + number2;
                        Console.WriteLine("O resultado é " + number1 + " + " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " + " + number2 + " = " + numberFinal;

                        break;
                    case 2:
                        numberFinal = number1 - number2;
                        Console.WriteLine("O resultado é " + number1 + " - " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " - " + number2 + " = " + numberFinal;
                        break;
                    case 3:
                        numberFinal = number1 * number2;
                        Console.WriteLine("O resultado é " + number1 + " * " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " * " + number2 + " = " + numberFinal;
                        break;
                    case 4:
                        if (number2 == 0)
                            {
                                MensagemInvalida("O segundo número não pode ser ZERO!");
                                Console.WriteLine("Escreva novamente o segundo número: ");
                                number2 = Convert.ToDecimal(Console.ReadLine());
                            }

                        numberFinal = number1 / number2;

                        Console.WriteLine("O resultado é " + number1 + " / " + number2 + " = " + numberFinal);
                        historico[operacoesH] = number1 + " / " + number2 + " = " + numberFinal;
                        break;
                }
                operacoesH++;
                Console.ReadLine();
            } while (ehVerdade == true);
        }
    }
}