using System;

namespace ChallengeIfStatements2
{
    internal class Program
    {
        static int currenthighscore = 250;
        static string currenthighscorePlayer = "Donna";

        static void Main(string[] args)
        {
            CheckHighScore(300, "Magda");
            CheckHighScore(220, "Ted");
            CheckHighScore(320, "Thanos");
            CheckHighScore(400, "Magda");

            Console.Read();
        }

        public static void CheckHighScore(int score, string playerName)
        {  
            if (score > currenthighscore)
            {
                currenthighscore = score; // updating score into the current high score
                currenthighscorePlayer = playerName; //updating playerName into the current highest score holder
                Console.WriteLine($"New high score is {currenthighscore}");
                Console.WriteLine($"New high score holder is {currenthighscorePlayer}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {currenthighscore} could not be broken and is still held by {currenthighscorePlayer}");
            }
        }
    }
}
