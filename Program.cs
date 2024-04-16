namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array cibi
            string[] cibiPreferiti = { "Pizza", "Patatine", "Sushi", "Pasta", "Cozze", "Arrosto", "Insalata" };

            //lunghezza array
            Console.WriteLine($"La lunghezza dell'array è: {cibiPreferiti.Length}");

            //stampa dell'intero array
            Console.WriteLine("cibi preferiti classificati: ");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1} = {cibiPreferiti[i]}");
            }

           
        }
    }
}
