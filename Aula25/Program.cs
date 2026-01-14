namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Find what is <span>between the tags</span>";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closePosition = message.IndexOf(closeSpan);

            

            // System.Console.WriteLine(openingPosition);
            // System.Console.WriteLine(closePosition);

            openingPosition += openSpan.Length;

            int length = closePosition - openingPosition;

            System.Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}