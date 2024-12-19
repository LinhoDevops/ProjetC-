internal class Program
{
    private static void Main(string[] args)
    {
        int nombre;
        string rep;

        Console.WriteLine("Ce programme permet de calculer la table de multiplication \n");

        do
        {
            do
            {
                Console.Write("Veillez saisir un nombre : ");
                nombre = int.Parse(Console.ReadLine());
            }
            while (nombre < 1);

            MultiplicationTable(nombre);
            Console.Write("Pour quitter appuiyer sur la lettre Q : ");
            rep = Console.ReadLine();
        }
        while (rep.ToLower() != "q");
    }

    /// <summary>
    /// Cette methode permet de retourner la table de multiplication d'un nombre 
    /// </summary>
    /// <param name="nombre"> Saisir  le nombre</param>
    public static void MultiplicationTable(int nombre)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($" {nombre} * {i} = {nombre * i}");
        }
    }
}