namespace Return_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string ReverseWord(string word)
            {
                string result = "";
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                return result;
            }

            System.Console.WriteLine(ReverseWord("Elefante"));

            string ReverseSetence(string input)
            {
                string result = "";

                string[] wordArray = input.Split(" ");

                foreach(string word in wordArray)
                {
                    string wordReverse = ReverseWord(word);
                    result += wordReverse + " ";
                }

                return result.Trim();
            }

            System.Console.WriteLine(ReverseSetence("tipo de retorno de cadeia de caracteres"));
        }
    }
}