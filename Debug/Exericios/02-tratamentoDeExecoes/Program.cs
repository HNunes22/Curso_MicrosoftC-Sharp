namespace ExceptionTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process1();
            }
            catch
            {
                System.Console.WriteLine("An exception has been caught.");
            }

            Console.WriteLine("Exit program");


        static void Process1()
        {
                try
                {
                  WriteMessage();  
                }
                catch(DivideByZeroException ex) // Aqui ele está preparado para tratar apenas a exeção DIVIDEBYZERO, nada mais.
                {
                    System.Console.WriteLine($"Exception caught in Process1: {ex.Message}");
                }
            
        }

        static void WriteMessage()
        {
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;
            byte smallNumber;

            Console.WriteLine(float1 / float2);
            Console.WriteLine(number1 / number2);
                // checked
                // {
                //     smallNumber = (byte) number1;
                // }
        }

        }
    }
}