using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIndexers_Demo
{
    internal class Backpack<T>
    {
        private T[] myStuff;
        private int count;

        public T this[int index]
        {
            get 
            {
                if (index < 0 || index >= count)
                {
                    throw new Exception($"Index {index} does not exist.");
                }

                return myStuff[index];
            }
            set { myStuff[index] = value; }
        }

        public int Count
        {
            get { return count; }
            // set { count = value; } // NO BAD GROSS
        }

        // DONT EVER DO THIS BAD DANGEROUS YOU ARE A BAD PROGRAMMER NO JUST KIDDING BUT DONT DO IT
        /*
        public string[] MyStuff
        {
            get { return myStuff; }
            set { myStuff = value }
        }
        */

        public Backpack()
        {
            myStuff = new T[3];
            count = 0;
            FillWithStartingDefaults();
        }

        private void FillWithStartingDefaults()
        {
            for(int i = 0; i < myStuff.Length; i++)
            {
                myStuff[i] = default(T);
            }
        }
        

        public void AddItem(T itemToAdd)
        {
            // Add item to the next available index
            myStuff[count] = itemToAdd;
            count++;

            // Array only holding 3 items!
            // What do I do with the 4th item?
            // That's a decision we need to make!
            // Not coding that RIGHT NOW - will do in the future
        }

        public void InspectContents()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(myStuff[i]);
            }
        }


        // What can we do with this Backpack?
        // - Put stuff in or take stuff out
        // - Search for specific things
        // - Take on, take off (equip)
        // - Inspect the contents
        // - Customize


        // Goal of the data structure:
        // THIS CLASS IS THE ONLY CLASS THAT SHOULD BE ABLE TO ADD TO OR MODIFY THE
        //   CONTENTS OF THE DATA BEING HELD! 
        // PROTECT THE DATA BY FORCING OTHER CLASSES TO CALL METHODS OF THIS CLASS
        //   TO CHANGE THIS DATA STRUCTURE!


        // ERIN: property that returns the myStuff array
        //       default expression to fill array with starting data
        //       private method vs. public method
        //       throwing exceptions
        //       make class generic
        //       write indexer
        //       write indexer with variables (not ideal but ok to show for now)

    }
}
