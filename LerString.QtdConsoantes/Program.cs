namespace LerString.ImpConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LEITOR E IMPRESSÃO DE CONSOANTES");
            Console.WriteLine("Digite uma palavra que deseja verificar:");
            var palavra = Console.ReadLine();

            foreach (char x in palavra)
            {
                if((x != 'a') & (x != 'e') & (x != 'i') & (x != 'o') & (x != 'u'))
                    Console.Write("{0} ", x);
            }
        }
    }
}