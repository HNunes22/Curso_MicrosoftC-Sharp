namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 =  Convert.ToInt32(value1 / value2);

            decimal result2 =  value2 / (decimal) value3;

            float result3 = (float) value3 / value1;

            System.Console.WriteLine($"First Result: {result1}");

            System.Console.WriteLine($"Second Result: {result2}");

            System.Console.WriteLine($"Third Result: {result3}");
        }
    }
}