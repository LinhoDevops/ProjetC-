
internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ce programme permet de calculer la factorielle d'un nombre \n : ");

        do
        {
            Console.Write("Veillez saisir un nombre : ");
            num = int.Parse(Console.ReadLine());
        } while (num < 0);
        int fac = factorielle(num);
        Console.WriteLine($"La factorielle de {num} est : {fac}");
        Console.ReadKey();

    }

    /// <summary>
    /// Cette methode permet de calculer la factorielle d'un nombre
    /// </summary>
    /// <param name="num"> Saisir un nombre</param>
    /// <returns> retourne la factorielle </returns>
    public static int factorielle(int num)
    {
        int fac = 1;
        for (int i = 1; i <= num; i++)
        {
            fac *= i;

        }
        return fac;
    }
    
}