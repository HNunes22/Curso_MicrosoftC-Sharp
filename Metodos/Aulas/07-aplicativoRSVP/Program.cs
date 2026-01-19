using System.Runtime.CompilerServices;

namespace AplicationRSVP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
            string[] rsvps = new string[10];
            int count = 0;


            RSVP("Rebecca", 1, "none", true);
            RSVP("Nadia", 2, "Nuts", true);
            RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly:  false);
            RSVP("Tony", 1, "Jackfruit", true);
            RSVP("Noor", 4, "none", false);
            RSVP("Jonte", 2, "Stone fruit", false);
            ShowRSVPs();

            void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly) 
            {
                if (inviteOnly)
                {
                    bool found = false;
                    foreach(string guest in guestList)
                    {
                        if (guest.Equals(name))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        System.Console.WriteLine($"Sorry, {name} is not on the guest list.");
                        return;
                    }
                }

                rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
                count++;
            }

            void ShowRSVPs()
            {
                Console.WriteLine("\nTotal RSVPs:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(rsvps[i]);
                }
            }
        }
    }
}