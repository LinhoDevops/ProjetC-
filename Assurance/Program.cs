internal class Program
{
    private static void Main(string[] args)
    {
        int montant;
        string rep;

        Console.WriteLine("Ce programme permet de calculerle montant a rembourse ainsi que la franchise \n");

        do
        {
            do
            {
                Console.Write("Veillez saisir un montant : ");
                montant = int.Parse(Console.ReadLine());
                
            }
            while (montant<1);

            Assurance(montant);
            Console.Write("Pour quitter appuiyer sur la lettre Q : ");
            rep = Console.ReadLine();
        }
        while (rep.ToLower() != "q");
    }

    /// <summary>
    /// Cette methode permet d'afficher le montant a rembourse ainsi que la franchise
    /// </summary>
    /// <param name="montant"> Saisir le montant </param>
    public static void Assurance(int montant)
    {
        double franche = montant * 0.1;
        Console.WriteLine($"Le montant a rembourse est {montant*0.9}");
        if (franche <= 4000)
        {
            Console.WriteLine($"LA franchise est {franche}");
        }else {
            franche = 4000;
            Console.WriteLine($"LA franchise est {franche}");
        }
            
    }
}