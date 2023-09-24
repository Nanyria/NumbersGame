﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
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
                    break;
                }
                else if (nr != winningNumMed && nr > winningNumMed)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    Console.WriteLine("Gissa igen!");
                }
                else if (nr != winningNumMed && nr < winningNumMed)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    Console.WriteLine("Gissa igen!");
                }

            }
        }


        //    bool choices = true;
            
        //    Console.WriteLine("Hej! Välkommen till gissa numret, välj din svårighetsgrad:");
        //    Console.WriteLine("[1] Enkel svårighetsgrad: Fem gissningar, nummer mellan 1-10.");
        //    Console.WriteLine("[2] Medel svårighetsgrad: Tre gissningar, nummer mellan 1-20.");
        //    Console.WriteLine("[3] Svår svårighetsgrad: En gissning, nummer mellan 1-30.");
        //    Console.WriteLine("[4] Avsluta programmet.");
        //    while (choices)
        //    {
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        if (choice == 1)
        //        {

        //        }
        //        else if (choice == 2)
        //        {

        //        }
        //        else if (choice == 3)
        //        {

        //        }
        //        else if (choice == 4)
        //        {

        //        }
        //        else
        //        {
        //            Console.WriteLine("Du måste välja ett nummer mellan 1-4´.");
        //        }
        //    }




        //    Console.WriteLine("Tack för att du spelade!");
        //    Console.ReadKey();


        //}
        //void Easy(string[] args)
        //{
        //    Random randomEasy = new Random();
        //    int winningNumEasy = randomEasy.Next(1, 11);
        //    int easyGuesses = 0;
        //    while (easyGuesses != 5)
        //    {
        //        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
        //        Console.WriteLine("Skriv det nummer du vill gissa på:");
        //        int nr = Convert.ToInt32(Console.ReadLine());
        //        if (nr == winningNumEasy)
        //        {
        //            Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumEasy);
        //            break;
        //        }
        //        else if (nr != winningNumEasy && nr > winningNumEasy)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för högt!");
        //        }
        //        else if (nr != winningNumEasy && nr < winningNumEasy)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för lågt!");
        //        }
        //    }
        //}
        //void Medium(string[] args)
        //{
        //    Random randomMed = new Random();
        //    int winningNumMed = randomMed.Next(1, 11);
        //    int medGuesses = 0;
        //    while (medGuesses != 5)
        //    {
        //        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
        //        Console.WriteLine("Skriv det nummer du vill gissa på:");
        //        int nr = Convert.ToInt32(Console.ReadLine());
        //        if (nr == winningNumMed)
        //        {
        //            Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumMed);
        //            break;
        //        }
        //        else if (nr != winningNumMed && nr > winningNumMed)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för högt!");
        //        }
        //        else if (nr != winningNumMed && nr < winningNumMed)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för lågt!");
        //        }

        //    }


        //}
        //void Hard(string[] args)
        //{
        //    Random randomHard = new Random();
        //    int winningNumHard = randomHard.Next(1, 11);
        //    int hardGuesses = 0;
        //    while (hardGuesses != 5)
        //    {
        //        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
        //        Console.WriteLine("Skriv det nummer du vill gissa på:");
        //        int nr = Convert.ToInt32(Console.ReadLine());
        //        if (nr == winningNumHard)
        //        {
        //            Console.WriteLine("Woho, du gjorde det! Rätt nummer var {0}!", winningNumHard);
        //            break;
        //        }
        //        else if (nr != winningNumHard && nr > winningNumHard)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för högt!");
        //        }
        //        else if (nr != winningNumHard && nr < winningNumHard)
        //        {
        //            Console.WriteLine("Tyvärr, du gissade för lågt!");
        //        }

        //    }


        //}

    }
}