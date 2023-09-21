namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Random randomEasy = new Random();
            Random randomHard = new Random();
            int winningNumEasy = random.Next(1, 11);
            int winningNumMed = random.Next(1, 21);
            int winningNumHard = random.Next(1, 31);
            int guesses = 0;
            Console.WriteLine("Hej! Välkommen till gissa numret, välj din svårighetsgrad:");
            Console.WriteLine("[1]Enkel svårighetsgrad: Fem gissningar, nummer mellan 1-10.");
            Console.WriteLine("[2]Medel svårighetsgrad: Tre gissningar, nummer mellan 1-20.");
            Console.WriteLine("[3]Svår svårighetsgrad: En gissning, nummer mellan 1-30.");
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                while (guesses != 5)
                {
                    Console.WriteLine("Skriv det nummer du vill gissa på:");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    if (nr == winningNumMed)
                    {
                        Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumMed);
                        break;
                    }
                    else if (nr != winningNumMed && nr > winningNumMed)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                    else if (nr != winningNumMed && nr < winningNumMed)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }

                }

            
           
            Console.WriteLine("Tack för att du spelade!");
            Console.ReadKey();


        }
    }
}