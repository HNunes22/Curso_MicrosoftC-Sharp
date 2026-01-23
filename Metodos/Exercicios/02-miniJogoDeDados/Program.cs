namespace MiniGameData
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");

            if (ShouldPlay()) 
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                string yesOrNo = Console.ReadLine().ToUpper();
                return yesOrNo == "Y" ? true : false;
            }


            string WinOrLose(int target, int roll)
            {
                if(target > roll || target == roll)
                {
                    return "You lose!";
                }
                else
                {
                    return "You Win";
                }
            }

            void PlayGame() 
            {
                var play = true;

                while (play) 
                {
                    var target = random.Next(1, 6);
                    var roll = random.Next(1, 7);

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(target, roll));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }
        }
    }
}