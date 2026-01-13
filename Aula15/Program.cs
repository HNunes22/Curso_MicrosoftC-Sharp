namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
      
            System.Console.WriteLine("Signed Integral types:");

            System.Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
            System.Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            System.Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            System.Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

            // ---------------------------------------------- //

            System.Console.WriteLine("");
            System.Console.WriteLine("Unsigned integral types:");

            System.Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
            System.Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
            System.Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
            System.Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
        
        }

        
    }
}