namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // Fazer o cursor sumir;

            Console.Clear(); // Limpar o console;

            // Escreve algo em posições diferentes

            Console.SetCursorPosition(5, 2); // Coluna: 5, Linha 2;
            System.Console.WriteLine("Olá");

            Console.SetCursorPosition(10, 5); // Coluna: 5, Linha 2;
            System.Console.WriteLine("Mundo!");

            Console.SetCursorPosition(0, 8); // Coluna: 5, Linha 2;
            System.Console.WriteLine("Pressione qualquer tecla para sair");

            // Console.ReadKey(); // Ler a tecla selecionada

            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // Argumento true significa: NÃO MOSTRAR A TECLA NO CONSOLE
            System.Console.WriteLine($"Key: {keyInfo.Key}");

            // System.Console.WriteLine(Console.WindowHeight);
            // Thread.Sleep(5000);
            // System.Console.WriteLine(Console.WindowWidth);
        }
    }
}