namespace ReusableMethod02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.WriteLine("A fortune teller whispers the following words:");
            ShowLuck();

            void ShowLuck()
            {
                int luck = random.Next(100);

                string[]? fortune;

                string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
                string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
                string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
                string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

                if(luck > 75) // Good
                {
                    fortune = good;
                }
                else if(luck < 25) // Bad
                {
                    fortune = bad;
                }
                else // Neutral
                {
                    fortune = neutral;
                }

                for (int i = 0; i < 4; i++) 
                {
                Console.Write($"{text[i]} {fortune[i]} ");
                }
            }


            // string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            
        }
    }
}