namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int daysUntilExpirate = random.Next(12);
            int discountPercetagem = 0;

            Console.WriteLine(daysUntilExpirate);
            if(daysUntilExpirate == 0)
            {
             Console.WriteLine("Your subscription has expired.");   
            }
            else if(daysUntilExpirate == 1)
            {
                discountPercetagem = 20;
                Console.WriteLine($"Your subscription expires within a day!");
            }
            else if(daysUntilExpirate <= 5)
            {
                discountPercetagem = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpirate} days.");
            }
            else
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if(daysUntilExpirate > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercetagem}%");
            }
            
        }
    }
}