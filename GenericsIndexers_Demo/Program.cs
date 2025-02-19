namespace GenericsIndexers_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack<string> myPack = new Backpack<string>();
            myPack.AddItem("first aid kit");
            myPack.AddItem("dynamite");
            myPack.AddItem("ham sandwich (and an ice pack so we don't get food poisoning)");

            Console.WriteLine("Here are the items in my pack: ");
            myPack.InspectContents();

            Console.WriteLine($"Right now, I am holding {myPack.Count} items.");
            //myPack.FillWithStartingDefaults();

            Console.WriteLine("Here are the items in my pack: ");
            myPack.InspectContents();

            Backpack<float> mySecondPack = new Backpack<float>();
            mySecondPack.AddItem(1.5f);
            mySecondPack.AddItem(100f);
            mySecondPack.InspectContents();

            Console.WriteLine("Here are the items in my pack: ");
            for (int i = 0; i < mySecondPack.Count; i++)
            {
                Console.WriteLine(mySecondPack[i]);
            }

            try
            {
                Console.WriteLine("Here is the 100th item : " + mySecondPack[101]);
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            float someValue = mySecondPack[100];
            mySecondPack[1] = 33333f;


            /*
            //myPack.Count = 111;
            // HAHA JUST KIDDING YOU ONLY HAVE 111 THING!!!!!!!
            Console.WriteLine("Here are the items in my pack: ");
            myPack.InspectContents();
            */

            /*
            Console.WriteLine($"Right now, I COULD hold {myPack.MyStuff.Length} items.");
            myPack.MyStuff[0] = "butt";
            myPack.MyStuff[1] = "butt";
            myPack.MyStuff[2] = "butt";
            myPack.InspectContents();
            */
        }
    }
}
