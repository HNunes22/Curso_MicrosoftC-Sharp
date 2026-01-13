namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] arrayOrderStrem = orderStream.Split(',');
            Array.Sort(arrayOrderStrem);
            foreach(var orderID in arrayOrderStrem)
            {
                if(orderID.Length == 4)
                {
                    System.Console.WriteLine(orderID);
                    continue;
                }
                System.Console.WriteLine($"{orderID}\t--Error");
            }
            
        }
    }
}