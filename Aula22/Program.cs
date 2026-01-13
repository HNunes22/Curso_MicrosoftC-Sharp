namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal price = 123.45m;
            // int discount = 50;
            // System.Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            System.Console.WriteLine("");

            decimal measurement = 123456.78912m;
            System.Console.WriteLine($"Measurement: {measurement:N} units");

            System.Console.WriteLine("");

            decimal tax = .36785m;
            System.Console.WriteLine($"Tax rate: {tax:P2}");

            System.Console.WriteLine("");

            decimal price = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

            Console.WriteLine(yourDiscount);
        }
    }
}