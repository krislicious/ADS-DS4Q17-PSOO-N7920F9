namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o seu RA:");
            string ra = Console.ReadLine();

            Validar validacao = new Validar(nome, ra);
            validacao.Validacao();
        }
    }
}