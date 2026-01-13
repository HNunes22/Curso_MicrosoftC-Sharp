namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] fraudulentsOrderID = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

            foreach (string IdProduct in fraudulentsOrderID)
            {
                if (IdProduct.StartsWith("B"))
                {
                    Console.WriteLine($"Alert Priority: {IdProduct}");
                }
            }
        }
    }
}