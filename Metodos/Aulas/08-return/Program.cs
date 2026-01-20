namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double minimumSpend = 30.0;

            double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
            double[] discount = {0.30, 0.00, 0.10, 0.20, 0.50};
            

            for(int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            if (TotalMeetsMinimum())
            {
                total -= 5.00;
            }

            System.Console.WriteLine($"Total: ${FormatDecimal(total)}");

            // Methods

            double GetDiscountedPrice(int itemIndex)
            {
                return items[itemIndex] * (1 - discount[itemIndex]);
            }

            bool TotalMeetsMinimum()
            {
              return total >= minimumSpend;  
            }

            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }
        }
    }
}