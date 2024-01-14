using System;
using System.Threading;

public class LocateSantaMiniGame
{
    public void PlayMiniGame()
    {
        Console.WriteLine("Du har vaknat på juldagen och inser att Tomten är försvunnen.");
        Console.WriteLine("Du måste hitta honom för att rädda julen!");

        int correctAnswers = 0;

        do
        {
            Console.WriteLine("\nDu står vid ditt hus och ser tre frågor om julen framför dig:");

            // Frågor med svarsalternativ
            string[] questions =
            {
                "Fråga 1: Vad öppnas varje dag i december och gömmer en överraskning?",
                "A) Julkalender",
                "B) Julklapp",
                "C) Garderob",
                "D) Kylskåpet",
                "A"
            };

            string[] questions2 =
            {
                "Fråga 2: Var bor Tomten?",
                "A) Nordpolen",
                "B) Sydpolen",
                "C) Kiruna",
                "D) New York",
                "A"
            };

            string[] questions3 =
            {
                "Fråga 3: Vad heter den berömda renen?",
                "A) Rolf",
                "B) Rudolf",
                "C) Rickard",
                "D) Rocky",
                "B"
            };

            // Fråga 1
            Console.WriteLine($"\n{questions[0]}");
            Console.WriteLine($"{questions[1]}\n{questions[2]}\n{questions[3]}\n{questions[4]}");

            string playerAnswer = GetPlayerAnswer();
            if (playerAnswer == questions[5])
            {
                Console.WriteLine("Rätt svar! Du är på rätt väg.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Fel svar. Rätt svar är: {questions[5]}");
            }

            // Fråga 2
            Console.WriteLine($"\n{questions2[0]}");
            Console.WriteLine($"{questions2[1]}\n{questions2[2]}\n{questions2[3]}\n{questions2[4]}");

            playerAnswer = GetPlayerAnswer();
            if (playerAnswer == questions2[5])
            {
                Console.WriteLine("Rätt svar! Du är på rätt väg.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Fel svar. Rätt svar är: {questions2[5]}");
            }

            // Fråga 3
            Console.WriteLine($"\n{questions3[0]}");
            Console.WriteLine($"{questions3[1]}\n{questions3[2]}\n{questions3[3]}\n{questions3[4]}");

            playerAnswer = GetPlayerAnswer();
            if (playerAnswer == questions3[5])
            {
                Console.WriteLine("Rätt svar! Du är på rätt väg.");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Fel svar. Rätt svar är: {questions3[5]}");
            }

            if (correctAnswers == 3)
            {
                Console.WriteLine("\nGrattis, du har hittat Tomten och räddat julen!");
                // Ge spelaren några sekunder att läsa meddelandet
                Thread.Sleep(3000);
                // Gå vidare till nästa del av spelet
                RepairSleighMiniGame repairSleighMiniGame = new RepairSleighMiniGame();
                repairSleighMiniGame.PlayMiniGame();
                break; // Avsluta spelet om alla frågor är korrekta
            }
            else
            {
                Console.WriteLine($"\nDu fick {correctAnswers} av 3 rätt. Vill du försöka igen?");
                Console.WriteLine("1. Försök igen");
                Console.WriteLine("2. Avsluta");

                int playerChoice = GetPlayerChoice(1, 2);

                if (playerChoice == 2)
                {
                    Console.WriteLine("\nTack för att du spelade! Spelet avslutas.");
                    break;
                }

                correctAnswers = 0; // Nollställ poängen vid omstart
            }

        } while (true);
    }

    private string GetPlayerAnswer()
    {
        string playerAnswer;
        do
        {
            Console.Write("Ditt svar (A, B, C eller D): ");
            playerAnswer = Console.ReadLine()?.ToUpper() ?? "";
        } while (playerAnswer != "A" && playerAnswer != "B" && playerAnswer != "C" && playerAnswer != "D");

        return playerAnswer;
    }

    private int GetPlayerChoice(int min, int max)
    {
        int choice;
        do
        {
            Console.Write("Ange ditt val: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
            {
                break;
            }
            Console.WriteLine("Ogiltigt val. Var god försök igen.");
        } while (true);

        return choice;
    }
}
