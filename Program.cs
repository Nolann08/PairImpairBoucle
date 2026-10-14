namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */

        int nombre;
        Console.WriteLine("Choissisez un nombre : ");
        nombre = Convert.ToInt32(Console.ReadLine());
        if (nombre % 2 == 0)
        {
            Console.WriteLine("Pair");
        }
        else if  (nombre % 2 == 1)
        {
            Console.WriteLine("Impaire");
        }

        Console.WriteLine("Voulez vous re demander un nombre ? (y/n)");
    }
}
