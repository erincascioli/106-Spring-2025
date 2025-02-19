namespace BackpackDemo_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack<float> myOtherStuff = new Backpack<float>();
            myOtherStuff.AddItem(3f);

            Console.WriteLine(myOtherStuff[0]);
            myOtherStuff[0] = 6f;




            Backpack<string> myStuff = new Backpack<string>();
            myStuff.AddItem("healing potion");      // Added!
            myStuff.AddItem("salt");                // Added!
            myStuff.AddItem("elevator");            // Added!
            myStuff.AddItem("car");                 // No space!

            Console.WriteLine($"I have {myStuff.Count} items in my pack.");
            Console.WriteLine("Here's what I am holding:");
            myStuff.PrintContents();

            int indexToRetrieve = 0;
            Console.WriteLine(myStuff.GetData(indexToRetrieve));

            try
            {
                Console.WriteLine(myStuff.GetData(5));
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            if(indexToRetrieve >= 0 && indexToRetrieve < myStuff.Count)
            {
                Console.WriteLine(myStuff.GetData(5));
            }

            // don't do these:
            //myStuff.Count = 0;
            // HAHA JUST KIDDING YOUR STUFF IS GONE

            //Console.WriteLine("Here's the first thing in my pack: " + myStuff.MyItems[0]);
            //myStuff.MyItems[0] = null;
            //myStuff.MyItems[1] = null;
            //myStuff.MyItems[2] = null;
        }
    }
}
