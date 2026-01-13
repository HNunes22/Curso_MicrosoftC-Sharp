namespace Aula10
{
    class Porgram
    {
        static void Main(string[] args)
        {
            string permission = "Manager|None";
            int level = 19;

            if (permission.Contains("Admin"))
            {
                string indentifyPermission = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user";
                Console.WriteLine(indentifyPermission);
            }
            else if(permission.Contains("Manager")) 
            {
                string indentifyPermission = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges. :(";
                Console.WriteLine(indentifyPermission);
            } 
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            } 
        }
    }
}