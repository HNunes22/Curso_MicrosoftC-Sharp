using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.CursorVisible = false; // Evitar o pisca do cursor no console

            int height = Console.WindowHeight - 1; // Retornar o valor da altura do console - 1;
            int width = Console.WindowWidth - 5; // Retornar o valor da largura do console - 5;

            bool shouldExit = false;

            // Console position of the player
            int playerX = 0; // LeftArrow: -1 and RightArrow: +1;
            int playerY = 0;// UpArrow: -1 and DownArrow: +1;

            // Console position of the food
            int foodX = 0;
            int foodY = 0;

            // Available player and food strings
            string[] states = {"('-')", "(^-^)", "(X_X)"}; // Estados do player
            string[] foods = {"@@@@@", "$$$$$", "#####"}; // Comidas

            // Current player string displayed in the Console
            string player = states[0];

            // Index of the current food
            int food = 0;

            InitializeGame();

            while (!shouldExit) 
            {
                Move(true);
                shouldExit = shouldExit || TerminalResized();
            }

            // Returns true if the Terminal was resized 
            bool TerminalResized() 
            {
                bool verification = height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;

                if (verification)
                {
                    Console.Clear();
                    System.Console.WriteLine("Console was resized. Program exiting.");
                } 

                return verification;
            }

            // Displays random food at a random location
            void ShowFood() 
            {
                // Update food to a random index
                food = random.Next(0, foods.Length);

                // Update food position to a random location
                foodX = random.Next(0, width - player.Length);
                foodY = random.Next(0, height - 1);

                // Display the food at the location
                Console.SetCursorPosition(foodX, foodY);

                Console.Write(foods[food]);
            }

            // Changes the player to match the food consumed
            void ChangePlayer() 
            {
                player = states[food];
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(player);
            }

            // Temporarily stops the player from moving
            void FreezePlayer() 
            {
                System.Threading.Thread.Sleep(1000); // Pausar o movimento do player
                player = states[0];
            }

            // Reads directional input from the Console and moves the player
            void Move(bool optionalExit = false, int movie = 1) 
            {
                int lastX = playerX;
                int lastY = playerY;

                VerifyEatFood(lastX, lastY);

                int playerVerify = VerifyStatePlayer(player);
                movie = playerVerify;
                
                var keyInfo = Console.ReadKey(true);
                
                switch (keyInfo.Key) 
                {
                    case ConsoleKey.UpArrow:
                        playerY--; 
                        break;
                    case ConsoleKey.DownArrow: 
                        playerY++; 
                        break;
                    case ConsoleKey.LeftArrow:  
                        playerX -= movie; 
                        break;
                    case ConsoleKey.RightArrow: 
                        playerX += movie; 
                        break;
                    case ConsoleKey.Escape: 
                        shouldExit = true; 
                        break;
                    default:
                        shouldExit = optionalExit;
                        break;
                }

                // Clear the characters at the previous position
                Console.SetCursorPosition(lastX, lastY);
                for (int i = 0; i < player.Length; i++) 
                {
                    Console.Write(" ");
                }

                // Keep player position within the bounds of the Terminal window
                playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
                playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

                // Draw the player at the new location
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(player);


                
            }

            void VerifyEatFood(int positionPlayerX, int positionPlayerY)
            {
                if(positionPlayerX == foodX && positionPlayerY == foodY)
                {
                    ChangePlayer();
                    ShowFood();
                }
            }

            int VerifyStatePlayer(string state)
            {

                if(state == "(X_X)")
                {
                    FreezePlayer();
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            // Clears the console, displays the food and player
            void InitializeGame() 
            {
                Console.Clear();
                ShowFood();
                Console.SetCursorPosition(0, 0);
                Console.Write(player);
            }
        }
    }
}