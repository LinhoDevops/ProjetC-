internal class Program
{
    private static void Main(string[] args)
    {
        int age;
        string rep;

        do
        {
            do
            {
                Console.WriteLine("Ce programme permet d'apprecier votre age  ");
                Console.Write("Veillez saisir votre age : ");
                age = int.Parse(Console.ReadLine());
            }
            while (age<1);

            Console.WriteLine(Apprecier(age));
            Console.Write("Pour quitter appuiyer sur la lettre Q : ");
            rep = Console.ReadLine();
        }
        while (rep.ToLower() != "q");
    }

    /// <summary>
    ///  Cette methode permet d'apprecier votre age
    /// </summary>
    /// <param name="age"> Saisir age</param>
    /// <returns> retourne appreciation</returns>
    public static string Apprecier(int age)
    {
        if (age < 16) { return " Vous etes Mineur"; }
        else if (age < 35) { return "Vous etes Adolescent"; }
        else return " Vous etes Adulte";
    }
    
}