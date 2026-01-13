namespace Aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Class Random

            string flip = random.Next(0,2) == 1 ? "Heads": "Tails"; // Determina pelo número aleatório se é Heads ou Tails

            Console.WriteLine(flip); // Exibe o resultado no console
        }
    }
}