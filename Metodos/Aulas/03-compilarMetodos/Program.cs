namespace MethodCompilation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string methodIPVResult = IpvFourGenerating();
            System.Console.WriteLine($"IPV4: {methodIPVResult}");
            // System.Console.WriteLine();
            VerifyValidIpvFour(methodIPVResult);
            // System.Console.WriteLine(methodIPVResult);


            // Methods


            int[] ConvertStringForIntengerArray(string[] numbers)
            {
                int[] intArrayNumbers = new int[4];

                for(int i = 0; i < intArrayNumbers.Length; i++)
                {
                    intArrayNumbers[i] = int.Parse(numbers[i]);
                }

                return intArrayNumbers;
            }


            void VerifyValidIpvFour(string ipv4)
            {

                if (ipv4.Contains("."))
                {
                    string[] convertingInArray = ipv4.Split(".");
                    bool checkLength = convertingInArray.Length == 4;

                    int[] intArray = ConvertStringForIntengerArray(convertingInArray);

                    
                    bool checkInterval = false;
                    bool checkLeftZero = false;

                    foreach (int ipvNumber in intArray)
                    {
                        if(ipvNumber >= 0 && ipvNumber <= 255)
                        {
                            checkInterval = true;
                        } else
                        {
                            checkInterval = false;
                            break;
                        }
                    }

                    for(int i = 0; i < 3; i++)
                    {
                        if(intArray[i] != 0)
                        {
                            checkLeftZero = true;
                        }
                        else
                        {
                            checkLeftZero = false;
                            break;
                        }
                    }
                    
                    // System.Console.WriteLine($"CheckLength: {checkLength}\nCheckInterval: {checkInterval}\nCheckLeftZero: {checkLeftZero}");

                    System.Console.WriteLine();

                    if(checkInterval && checkLength && checkLeftZero)
                    {
                        System.Console.WriteLine("IPV4 VALID!");
                    }
                    else
                    {
                        System.Console.WriteLine("IPV4 INVALID!");
                    }

                }
                else
                {
                    System.Console.WriteLine("IPV4 INVALID!");
                }
                

            }


            string IpvFourGenerating()
            {
                string[] stringNumbers = new string[4];
                for(int i = 0; i < stringNumbers.Length; i++)
                {
                    int ipvFourNumber = random.Next(0, 290);
                    stringNumbers[i] = ipvFourNumber.ToString();
                }
                
                string formatingIpv4 = string.Join(".", stringNumbers);
                return formatingIpv4;
            }
        }
    }
}