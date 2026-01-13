namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inventory = {110, 890, 625, 911, 822, 349};
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in iventory");
        }
    }
}