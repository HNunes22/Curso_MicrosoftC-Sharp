namespace Aula2
{
    class Porgram
    {
        static void Main(string[] args)
        {
            // Variables Dice, Rolls and Bonus

            Random dice = new Random();

            int roll = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int totalRolls = roll + roll2 + roll3;

            int bonusDoubled = 0;

            // Logic Bonus

            if((roll == roll2) || (roll == roll3) || (roll2 == roll3))
            {

                if ((roll == roll2) && (roll2 == roll3))
                {
                    bonusDoubled = 6;
                    totalRolls += bonusDoubled;
                    Console.WriteLine("WOW! You Roulled Triplate! Here is your bonus! +6");
                }
                else
                {
                    bonusDoubled = 2;
                    totalRolls += bonusDoubled;
                    Console.WriteLine("Yes! You Roulled double! Here is your bonus! +2");
                }
            }

            Console.WriteLine($"Dice rolls: {roll} + {roll2} + {roll3} + {bonusDoubled} = {totalRolls}");
            
            // Rewards

            if(totalRolls >= 15)
            {
                Console.WriteLine("You win a new car!");
            }
            else if(totalRolls >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if(totalRolls == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }
    }
}