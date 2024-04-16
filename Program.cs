namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array cibi
            string[] cibiPreferiti = { "Pizza", "Patatine", "Sushi", "Pasta", "Cozze", "Arrosto", "Rollè di Patate", "Insalata" };

            //lunghezza array
            Console.WriteLine($"La lunghezza dell'array è: {cibiPreferiti.Length}");

            //stampa dell'intero array
            Console.WriteLine("cibi preferiti classificati: ");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1} = {cibiPreferiti[i]}");
            }

            //cibo preferito in assoluto
            Console.WriteLine($"Cibo preferito in assoluto: {cibiPreferiti[0]}");

            //cibo preferito ma non troppo
            int ciboUltimo = cibiPreferiti.Length - 1;
            Console.WriteLine($"Cibo preferito ma non troppo: {cibiPreferiti[ciboUltimo]}");

            //cibo preferito intermedio
            int ciboIntermedio = cibiPreferiti.Length /2;

            //condizione per cibo intermedio
            if (cibiPreferiti.Length % 2 == 0)
            {
                Console.WriteLine($"Cibo preferito intermedio 1: {cibiPreferiti[ciboIntermedio - 1]}");
                Console.WriteLine($"Cibo preferito intermedio 2: {cibiPreferiti[ciboIntermedio]}");
            }else
            {
                Console.WriteLine($"Cibo preferito intermedio: {cibiPreferiti[ciboIntermedio]}");
            }
        }
    }
}
