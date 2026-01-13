namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            System.Console.WriteLine($" Shares: {productShares:N3} Product");
            System.Console.WriteLine($"  Sub Total: {subtotal:C}");
            System.Console.WriteLine($"   Tax: {taxPercentage:P2}");
            System.Console.WriteLine($"    Total Billed: {total:C}");
        }
    }
}