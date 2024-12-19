
internal class Program
{
    private static void Main(string[] args)
    {
        string nom, prenom, email, rep;

        Console.Write("Ce progamme permet d'afficher les infos d'une personne \n ");
        do
        {
            Console.Write("Veillez saisir votre nom : ");

            nom = Console.ReadLine();

            Console.Write("Veillez saisir votre prenom : ");
            prenom = Console.ReadLine();

            Console.Write("Veillez saisir votre email : ");
            email = Console.ReadLine();

            Console.WriteLine($"Bonjour {prenom} {nom} votre email est : {email}");
            Console.Write("Pour quitter Appuiyer sur Q : ");
            rep = Console.ReadLine();

        } while (rep.ToLower().Substring(1) != "q");
    }
}