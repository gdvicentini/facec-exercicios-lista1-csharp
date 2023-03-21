namespace Calculadora.Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, val1, val2;
            double result;

            Console.WriteLine("Calculadora C#:\n");
            Console.WriteLine("Selecione uma das opções abaixo que deseja executar:");
            Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n5 - Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            while(opcao != 5)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o primeiro valor");
                        val1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor");
                        val2 = Convert.ToInt32(Console.ReadLine());

                        result = val1 + val2;

                        Console.WriteLine("O resultado dessa soma é: " + result);
                        break;

                    case 2:
                        Console.WriteLine("Informe o primeiro valor");
                        val1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor");
                        val2 = Convert.ToInt32(Console.ReadLine());

                        result = val1 - val2;

                        Console.WriteLine("O resultado dessa subtração é: " + result);
                        opcao = 0;
                        break;

                    case 3:
                        Console.WriteLine("Informe o primeiro valor");
                        val1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor");
                        val2 = Convert.ToInt32(Console.ReadLine());

                        result = val1 * val2;

                        Console.WriteLine("O resultado dessa multiplicação é: " + result);
                        break;

                    case 4:
                        Console.WriteLine("Informe o primeiro valor");
                        val1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor");
                        val2 = Convert.ToInt32(Console.ReadLine());

                        result = val1 / val2;

                        Console.WriteLine("O resultado dessa divisão é: " + result);
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        Console.WriteLine("Programa encerrado");
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}