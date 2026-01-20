namespace Return_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

            foreach (string word in words)
            {
                System.Console.WriteLine($"{word}: {isPalidrome(word)}");
            }

            bool isPalidrome(string word)
            {
                string reversedWord = "";
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                } 

                return reversedWord == word;
            }
        }
    }
}