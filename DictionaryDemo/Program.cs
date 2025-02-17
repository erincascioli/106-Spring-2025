
// Erin Cascioli
// 2/14/25
// Demo: Dictionary Syntax

namespace DictionaryDemo
{
    internal class Program
    {
        /// <summary>
        /// Enum used as the value in the dictionary below.
        /// </summary>
        public enum Franchise
        {
            Kirby,
            Splatoon,
            MonsterHunter,
            Diablo,
            GodOfWar
        }

        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declare a dictionary that maps a key to a value
            // ----------------------------------------------------------------
            Dictionary<string, Franchise> franchises = new Dictionary<string, Franchise>();

            // ----------------------------------------------------------------
            // Add key-value pairs, called dictionary "entries", to the dictionary
            // ----------------------------------------------------------------
            franchises.Add("Wren", Franchise.Kirby);
            franchises.Add("Sam P.", Franchise.Splatoon);
            franchises.Add("Alejandro", Franchise.MonsterHunter);
            franchises.Add("Sam H.", Franchise.GodOfWar);

            // ----------------------------------------------------------------
            // Use the ContainsKey method before attempting to access data in the dictionary
            // ----------------------------------------------------------------
            if (franchises.ContainsKey("Sam P."))
            {
                Console.WriteLine(franchises["Sam P."]);
            }
            if(franchises.ContainsKey("Bob"))
            {
                Console.WriteLine(franchises["Bob"]);
            }

            // ----------------------------------------------------------------
            // Should you use exception handling to prevent a crash upon accessing 
            //   non-existant data?
            // Nope!  It's unnecessary!  Anytime you can prevent an error with a
            //   conditional and simplistic error checking (like the ContainsKey method),
            //   do so!  Handling thrown exceptions is expensive.
            // ----------------------------------------------------------------
            /*
            try
            {
                Console.WriteLine(franchises["Bob"]);
            }
            catch(Exception error)
            {
                Console.WriteLine("Bob is not in the dictionary.");
            }
            */


            // ----------------------------------------------------------------
            // Example from section 2 at 12 noon
            // ---------------------------------------------------------------
            Dictionary<string, string> lunchOrders = new Dictionary<string, string>();
            lunchOrders.Add("Nasir", "Mozzarella sticks");
            lunchOrders.Add("Mat", "Potato pancakes");
            lunchOrders.Add("Sienna", "Salmon avocado sushi");
            lunchOrders.Add("Rowan", "Triple double bacon cheeseburger with an onion ring on top, no pickles");
            lunchOrders.Add("Cortland", "Calzone");

            if(lunchOrders.ContainsKey("Sienna"))
            {
                Console.WriteLine(lunchOrders["Sienna"]);
            }
            if(lunchOrders.ContainsKey("Nobody"))
            {
                Console.WriteLine(lunchOrders["Nobody"]);
            }
        }
    }
}
