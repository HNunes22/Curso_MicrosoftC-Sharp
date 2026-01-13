namespace Aula17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = ["12,3", "45", "ABC", "11", "DEF"];

            string message = "";
            decimal total = 0m; 

            foreach (var value in values)
            {   
                decimal number;

                if(decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            System.Console.WriteLine($"Message: {message}");
            System.Console.WriteLine($"Total: {total}");
        }
    }
}