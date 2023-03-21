namespace LerString.QtdVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contador;
            Console.WriteLine("LEITOR E CONTADOR DE VOGAIS");
            Console.WriteLine("Digite uma palavra que deseja verificar:");
            var palavra = Console.ReadLine();

            Console.WriteLine("Quantidade de vogais: " + palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u')));
        }
    }
}