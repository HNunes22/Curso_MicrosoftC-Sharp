namespace Return_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 23.73;
            int vnd = UsdToVnd(usd);

            System.Console.WriteLine($"${usd} USD = ${vnd} VND");
            System.Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

            int UsdToVnd(double usd)
            {
                int rate = 23500;
                return (int) (rate * usd);
            }

            double VndToUsd(int vnd)
            {
                double rate = 23500;
                return vnd / rate;
            }
        }
    }
}