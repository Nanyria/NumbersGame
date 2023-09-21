namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int index = random.Next(1, 21);
            int guesses = 5;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            
            int nr = Convert.ToInt32(Console.ReadLine());
            while (guesses < 5) 
            {
                Console.WriteLine("Skriv det nummer du vill gissa på:");
                if (nr == index && guesses <= 5)
                {
                    Console.WriteLine("Grattis! Du gissade rätt! Rätt nummer var {0}!", index);
                    break;
                }
                else if (nr != index && guesses < 5)
                {
                    Console.WriteLine("Nej, det var fel gissning, ");
                }

            }
            Console.WriteLine("Tack för att du spelade!");
            Console.ReadKey();


        }
    }
}