using System.Runtime.InteropServices.Marshalling;

namespace DiceGame_Marre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int dealerScore = 0;
            int playerCardValue = 0;
            int aceAmount = 0;
            int aceValue = 0;
            int playerScorePlusAce = 0;
            string playerSuit;
            string playerCard = "Blank";
            Random rand = new Random();


            Console.WriteLine("Välkommen till Black Jack!");
            

            while (1 == 1)
            {
                for(int i = 0; i < 2; i++)
                {
                    //Dra fram slumpvärden
                    int playerRandomSuitGiv = rand.Next(1, 5);
                    int playerRandomCardGiv = rand.Next(1, 14);
                    //Konvertera slumpvärde till kortfärg
                    if (playerRandomSuitGiv == 1)
                    { playerSuit = "Klöver"; }
                    else if (playerRandomSuitGiv == 2)
                    { playerSuit = "Ruter"; }
                    else if (playerRandomSuitGiv == 3)
                    { playerSuit = "Hjärter"; }
                    else
                    { playerSuit = "Spader"; }
                    //Konvertera slumpvärde till kort
                    if (playerRandomCardGiv > 1 && playerRandomCardGiv < 11)
                    {
                        playerCard = playerRandomCardGiv.ToString();
                        playerCardValue = playerRandomCardGiv;
                    }
                    else if (playerRandomCardGiv == 11)
                    {
                        playerCard = "Knekt";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 12)
                    {
                        playerCard = "Dam";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 13)
                    {
                        playerCard = "Kung";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 1)
                    {

                        playerCard = "Ess";
                        playerCardValue = 0;
                        aceAmount += 1;
                    }
                    
                    if (aceAmount >= 1)
                    {
                        if (playerScore + 11 > 21)
                        {
                            aceValue = aceAmount;
                        }
                        else
                        {
                            aceValue = 10 + aceAmount;
                        }
                    }
                    
                    if (i == 0)
                    {
                        playerScore = playerCardValue;
                        Console.Write("Dina två första kort är "+playerSuit+" "+playerCard);
                        continue;
                    }
                    else if(i==1)
                    {
                        playerScore += playerCardValue;
                        playerScorePlusAce = aceValue + playerScore;
                        Console.WriteLine(" och " + playerSuit + " " + playerCard + ". Din poäng är " + playerScorePlusAce + ".");
                    }
                }
                

                Console.WriteLine("Vill du slå eller stanna?");
                string ans = Console.ReadLine().ToLower().Trim();
                while (ans != "stanna" && playerScore < 21 && dealerScore <= 21)
                {
                    //Om svaret är ogiltigt
                    if (ans != "slå")
                    {
                        Console.WriteLine("Ogiltigt svar. Skriv slå eller stanna.");
                        ans = Console.ReadLine().ToLower().Trim();
                        continue;
                    }
                    //Dra fram slumpvärden
                    int playerRandomSuitGiv = rand.Next(1, 5);
                    int playerRandomCardGiv = rand.Next(1, 2);
                    //Konvertera slumpvärde till kortfärg
                    if (playerRandomSuitGiv == 1)
                    { playerSuit = "Klöver"; }
                    else if (playerRandomSuitGiv == 2)
                    { playerSuit = "Ruter"; }
                    else if (playerRandomSuitGiv == 3)
                    { playerSuit = "Hjärter"; }
                    else
                    { playerSuit = "Spader"; }
                    //Konvertera slumpvärde till kort
                    if (playerRandomCardGiv > 1 && playerRandomCardGiv < 11)
                    {
                        playerCard = playerRandomCardGiv.ToString();
                        playerCardValue = playerRandomCardGiv;
                    }
                    else if (playerRandomCardGiv == 11)
                    {
                        playerCard = "Knekt";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 12)
                    {
                        playerCard = "Dam";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 13)
                    {
                        playerCard = "Kung";
                        playerCardValue = 10;
                    }
                    else if (playerRandomCardGiv == 1)
                    {

                        playerCard = "Ess";
                        playerCardValue = 0;
                        aceAmount += 1;
                    }

                    if (aceAmount >= 1)
                    {
                        if (playerScore + 11 > 21)
                        {
                            aceValue = aceAmount;
                        }
                        else
                        {
                            aceValue = 10 + aceAmount;
                        }
                    }
                    playerScore += playerCardValue;
                    playerScorePlusAce = playerScore + aceValue;
                    Console.WriteLine("Du drog " + playerSuit + " " + playerCard+". Din totala poäng är "+playerScorePlusAce);

                    Console.WriteLine("Vill du slå eller stanna?");
                    ans = Console.ReadLine().ToLower().Trim();

                    if (playerScore == 21)
                    {
                        Console.WriteLine("Du vann");
                    }

                }
            }
          

                
        }
    }
}
