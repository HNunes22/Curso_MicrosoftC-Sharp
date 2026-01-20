namespace AdressEmailEmployees
{
    class Program
    {
        static void Main(string[] args)
        {

            // Internal:

            string[,] corporate = 
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            

            //External

            string[,] external = 
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };


            

            // Methods

            void verifyEmailExternalEmployees(string lastname, string firstName = "None")
            {
                string externalDomain = "@hayworth.com";
                string twoLettersNameAndLastname = firstName.Substring(0, 2).ToLower() + lastname.ToLower();
                // string lastNameLower = lastname.ToLower(); 

                string emailExternalEmployees = twoLettersNameAndLastname + externalDomain;
                System.Console.WriteLine(emailExternalEmployees);
            }


            for (int i = 0; i < external.GetLength(0); i++) 
            {
                // display external email addresses

                for(int j = 0; j < external.GetLength(1); j++) // Cuida das colunas
                {
                        string firstName = external[i, 0];
                        string lastName = external[i, 1];
                        verifyEmailExternalEmployees(lastName, firstName);
                        break;
                }
            }



            void verifyEmailInternalEmployees(string lastname, string firstName = "None")
            {
                string internalDomain = "@contoso.com";
                string twoLettersNameAndLastname = firstName.Substring(0, 2).ToLower() + lastname.ToLower();
                // string lastNameLower = lastname.ToLower(); 

                string emailInternalEmployees = twoLettersNameAndLastname + internalDomain;
                System.Console.WriteLine(emailInternalEmployees);
            }


            for (int i = 0; i < corporate.GetLength(0); i++) // Cuida das linhas
            {
                // display internal email addresses

                for(int j = 0; j < corporate.GetLength(1); j++) // Cuida das colunas
                {
                    string firstName = corporate[i, 0];
                    string lastName = corporate[i, 1];
                    verifyEmailInternalEmployees(lastName, firstName);
                    break;
                }  
            }
        }
    }
}