namespace remove_Replace
{
    class Program
    {
        static void Main(string[] args)
        {

            // Remove()

            string data = "12345John Smith         5000 3   ";

            string updateData = data.Remove(5, 20); // Remove(index, quantidade);

            System.Console.WriteLine(updateData);

            System.Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");

            // Replace()

            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " "); // Replace("substituir o que?", "para o que?");
            message = message.Replace("-", "");
            System.Console.WriteLine(message);

        }
    }
}