namespace BouclesExo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int resultat = 1;
            int i = 1;


        Console.WriteLine("Entrez un nombre entier positif :");
        n = int.Parse(Console.ReadLine());

        while (i <= n)
            {
                resultat *= i;
                i++;
            }
            Console.WriteLine("Le factoriel de {0} est {1}", n, resultat);
        }
    }
}
