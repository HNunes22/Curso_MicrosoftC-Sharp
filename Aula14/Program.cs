namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lifeCurrentHero = 10;
            int lifeCurrentMonster = 10;

            int randomAttackHero = 0;
            int randomAttackMonster = 0;

            string winnerGame = "";

            while (true)
            {
                    randomAttackHero = random.Next(1, 11);
                    lifeCurrentMonster -= randomAttackHero;
                    System.Console.WriteLine($"Monster was damaged and lost {randomAttackHero} health and now has {lifeCurrentMonster} health.");

                    if(lifeCurrentMonster <= 0)
                    {
                        winnerGame = "Hero";
                        break;
                    }

                    randomAttackMonster = random.Next(1, 11);
                    lifeCurrentHero -= randomAttackMonster;
                    System.Console.WriteLine($"Hero was damaged and lost {randomAttackMonster} health and now has {lifeCurrentHero} health.");

                    if(lifeCurrentHero <= 0)
                    {
                        winnerGame = "Monster";
                        break;
                    }
                
            } 

            System.Console.WriteLine($"{winnerGame} Wins!");

        }
    }
}