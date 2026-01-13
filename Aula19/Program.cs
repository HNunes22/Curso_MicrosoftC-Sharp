namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = ["B12", "A13", "C65", "B11"];

            System.Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                System.Console.WriteLine("--" + pallet);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                System.Console.WriteLine($"--{pallet}");
            }

            System.Console.WriteLine("");
            System.Console.WriteLine($"Before: {pallets[0]}");
            Array.Clear(pallets, 0, 2);
            System.Console.WriteLine($"After: {pallets[0]}");
            System.Console.WriteLine($"Clearing 2... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                if(pallet == null)
                {
                    continue;
                }
                System.Console.WriteLine($"--{pallet}");
            }

            System.Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
            pallets[4] = "B55";
            pallets[5] = "A15";
            foreach(var pallet in pallets)
            {
                System.Console.WriteLine($"--{pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            System.Console.WriteLine("");

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            System.Console.WriteLine(result);
            string[] items = result.Split(',');
            foreach(string item in items)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
