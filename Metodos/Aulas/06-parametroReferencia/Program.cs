namespace ReferenceParamenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type

            int a = 3;
            int b = 4;
            int c = 0; // Result

            Multiply(a, b , c);

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                System.Console.WriteLine($"{a} x {b} = {c}");
            }

            System.Console.WriteLine();
        
            // Reference Type

            int[] array = {1, 2, 3, 4, 5};

            PrintArray(array);
            Clear(array);
            PrintArray(array);


            void PrintArray(int[] arrayNumbers)
            {
                foreach(int a in arrayNumbers)
                {
                    System.Console.Write($"{a} ");
                }
                System.Console.WriteLine();
            }

            void Clear(int [] arrayNumbers)
            {
                for(int i = 0; i < arrayNumbers.Length; i++)
                {
                    array[i] = 0;
                }
            }

        }
    }
}