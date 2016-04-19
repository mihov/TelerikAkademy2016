using System;

class PlayCard
{
    static void Main()
    {
        string[] cardSigns = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        string currentCard = Console.ReadLine();

        Console.WriteLine((Array.IndexOf(cardSigns, currentCard) > -1) ? "yes " + currentCard : "no " + currentCard);
    }
}