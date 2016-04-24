using System;

class PrintaDeck
{
    static void Main()
    {
        string[] suits = { "spades", "clubs", "hearts", "diamonds" };
        string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        string countToThisCard = Console.ReadLine();
        int countToThisCardIndex = Array.IndexOf(cardFaces, countToThisCard);

        for (int facesCounter = 0; facesCounter <= countToThisCardIndex; facesCounter++)
        {
            for (int suitsCounter = 0; suitsCounter < 4; suitsCounter++)
            {
                Console.Write("{0} of {1}{2}", cardFaces[facesCounter], suits[suitsCounter], ((suitsCounter < 3) ? ", " : "\n"));

            }
        }
    }
}
