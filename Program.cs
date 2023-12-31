﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Meny();

        }
        public static void Meny()
        {
            Console.WriteLine("Hej! Välkommen till gissa numret, välj din svårighetsgrad:");
            Console.WriteLine("[1] Enkel svårighetsgrad: Fem gissningar, nummer mellan 1-10.");
            Console.WriteLine("[2] Medel svårighetsgrad: Tre gissningar, nummer mellan 1-20.");
            Console.WriteLine("[3] Svår svårighetsgrad: En gissning, nummer mellan 1-30.");
            Console.WriteLine("[4] Avsluta programmet.");
            string choice = Console.ReadLine();
            int result = 0;
            if (Int32.TryParse(choice, out result) || (result >= 1 && result < 5))
            {
                switch (result)
                {
                    case 1:
                        Program.Easy();
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    case 2:
                        Program.Medium();
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    case 3:
                        Program.Hard();
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    case 4:
                        Console.WriteLine("Tack för att du spelade!");
                        Console.ReadKey();
                        break;

                }
            }
            else
            {
                Console.WriteLine("Du måste välja ett nummer mellan 1-4.");
            }


        }
        public static void Easy()
        {
            Random randomEasy = new Random();
            int winningNumEasy = randomEasy.Next(1, 11);
            int easyGuesses = 0;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            while (easyGuesses != 5)
            {

                Console.WriteLine("Skriv det nummer du vill gissa på:");
                int nr = Convert.ToInt32(Console.ReadLine());
                if (nr == winningNumEasy)
                {
                    Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumEasy);
                    Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                    int playAgain = Convert.ToInt32(Console.ReadLine());
                    switch (playAgain)
                    {
                        case 1:
                            Console.Clear();
                            Program.Meny();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }
                else if (nr != winningNumEasy && nr > winningNumEasy)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    easyGuesses++;
                }
                else if (nr != winningNumEasy && nr < winningNumEasy)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    easyGuesses++;
                }
            }
            if (easyGuesses >= 5)
            {
                Console.WriteLine("Du har använt alla dina gissningar, du förlorade!");
                Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                int playAgain = Convert.ToInt32(Console.ReadLine());
                switch (playAgain)
                {
                    case 1:
                        Console.Clear();
                        Program.Meny();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static void Medium()
        {
            Random randomMed = new Random();
            int winningNumMed = randomMed.Next(1, 21);
            int medGuesses = 0;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            while (medGuesses != 5)
            {
                Console.WriteLine("Skriv det nummer du vill gissa på:");
                int nr = Convert.ToInt32(Console.ReadLine());
                if (nr == winningNumMed)
                {
                    Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumMed);
                    Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                    int playAgain = Convert.ToInt32(Console.ReadLine());
                    switch (playAgain)
                    {
                        case 1:
                            Console.Clear();
                            Program.Meny();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }
                else if (nr != winningNumMed && nr > winningNumMed)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    medGuesses++;
                }
                else if (nr != winningNumMed && nr < winningNumMed)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    medGuesses++;
                }

            }
            if (medGuesses >= 5)
            {
                Console.WriteLine("Du har använt alla dina gissningar, du förlorade!");
                Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                int playAgain = Convert.ToInt32(Console.ReadLine());
                switch (playAgain)
                {
                    case 1:
                        Console.Clear();
                        Program.Meny();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }

        }
        public static void Hard()
        {
            Random randomHard = new Random();
            int winningNumHard = randomHard.Next(1, 11);
            int hardGuesses = 0;
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            while (hardGuesses != 1)
            {
                Console.WriteLine("Skriv det nummer du vill gissa på:");
                int nr = Convert.ToInt32(Console.ReadLine());
                if (nr == winningNumHard)
                {
                    Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumHard);
                    Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                    int playAgain = Convert.ToInt32(Console.ReadLine());
                    switch (playAgain)
                    {
                        case 1:
                            Console.Clear();
                            Program.Meny();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                }
                else if (nr != winningNumHard && nr > winningNumHard)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    hardGuesses++;
                }
                else if (nr != winningNumHard && nr < winningNumHard)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    hardGuesses++;
                }

            }
            if (hardGuesses >= 1)
            {
                Console.WriteLine("Du har använt alla dina gissningar, du förlorade!");
                Console.WriteLine("Vill du spela igen? Tryck [1], för att avsluta, tryck [2].");
                int playAgain = Convert.ToInt32(Console.ReadLine());
                switch (playAgain)
                {
                    case 1:
                        Console.Clear();
                        Program.Meny();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
            

        }


    }
}