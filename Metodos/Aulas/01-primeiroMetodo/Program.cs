
namespace FirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Generating numbers: ");

            DisplayEvenOrOddNumber();

            void DisplayEvenOrOddNumber()
            {
                Random random = new Random();

                int evenCount = 0;
                int oddCount = 0;

                for(int i = 0; i <= 10; i++)
                {
                    int randomNumber = random.Next(1, 101);

                    if(randomNumber % 2 == 0)
                    {
                        System.Console.WriteLine($"{randomNumber} is Even!");
                        evenCount++;
                    }
                    else
                    {
                        System.Console.WriteLine($"{randomNumber} is Odd!");
                        oddCount++;
                    }
                }
                System.Console.WriteLine();
                CountWinnerEvenOrOdd(evenCount, oddCount);
            }


            void CountWinnerEvenOrOdd(int countEven, int countOdd)
            {
                if(countEven > countOdd)
                {
                    System.Console.WriteLine("Even Win!");
                }

                else if(countEven < countOdd)
                {
                    System.Console.WriteLine("Odd Win!");
                }
                else
                {
                    System.Console.WriteLine("Draw!");
                }
            }
            
        }

        static void SayHello(string name)
        {
            System.Console.WriteLine($"Hello, {name}!");
        } 
    }
}