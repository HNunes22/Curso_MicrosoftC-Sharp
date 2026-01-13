namespace Aula20
{
    class Program
    {
        static void Main(string[] args)
        {
           string pangram = "The quick brown fox jumps over the lazy dog"; 
           string[] pangramArray = pangram.Split(' ');
           string[] resultNewPangram = new string[pangramArray.Length];

           for(int i = 0; i < pangramArray.Length; i++)
            {
                char[] letters = pangramArray[i].ToCharArray();
                Array.Reverse(letters);
                resultNewPangram[i] =  new string(letters);
            }

            string result = String.Join(' ', resultNewPangram);
            System.Console.WriteLine(result);

        }
    }
}