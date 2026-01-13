namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "bad";
            int result = 0;

            if(int.TryParse(value, out result))
            {
                System.Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                System.Console.WriteLine("Unable to report the measurement.");
            }

            if(result > 0)
            {
                System.Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            }
        }
            
    }
}