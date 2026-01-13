namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            System.Console.WriteLine($"Dear {customerName},");
            System.Console.WriteLine($"As a customer of our {currentProduct} offering we are exited to tell you about a new financial product that would dramatically increase your return.");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
            System.Console.WriteLine("");

            Console.WriteLine("Here's a quick comparison:\n");

            int lengthCurrentProduct = currentProduct.Length + 10;
            int lengthNewProduct = newProduct.Length + 6;

            string comparisonMessage = $"{currentProduct.PadRight(lengthCurrentProduct)}{currentReturn:P}\t{currentProfit:C}\n{newProduct.PadRight(lengthNewProduct)}{newReturn:P2}\t{newProfit:C}";

            // Your logic here

            Console.WriteLine(comparisonMessage);
        }
    }
}