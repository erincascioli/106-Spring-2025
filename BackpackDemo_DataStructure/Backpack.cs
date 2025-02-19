using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackDemo_DataStructure
{
    internal class Backpack<T>
    {
        public T[] myItems;
        public int count;

        public string var1;
        public string var2;

        //public T this[int index]        // public T GetData(int index)
        //{
        //    get { return myItems[index]; }
        //    set { myItems[index] = value; }
        //}

        public string this[char varChar]        // public T GetData(int index)
        {
            get 
            {
                if (varChar == 'X')
                {
                    return var1;
                }
                else if(varChar == 'Y')
                {
                    return var2;
                }

                return "";
            }
        }



        public int Count
        {
            get { return count; }
            //set { count = value; }
        }

        // NO NO BAD DANGEROUS INSECURE
        //public string[] MyItems
        //{
        //    get { return myItems; }
        //}

        public Backpack()
        {
            myItems = new T[3];
            FillData();

            var1 = "A";
            var2 = "B";
        }

        private void FillData()
        {
            for(int i = 0; i < myItems.Length; i++)
            {
                myItems[i] = default(T)!;
            }
        }

        public Backpack(int size)
        {
            myItems = new T[size];
        }

        public bool AddItem(T itemToAdd)
        {
            // ONLY add item when there is space
            if(count < myItems.Length)
            {
                myItems[count] = itemToAdd;
                count++;
                return true;
            }

            return false;
        }

        public T GetData(int index)
        {
            if(index >= 0 && index < count)
            {
                return myItems[index];
            }

            throw new Exception("Index not found, exceeds size of the array or is too small");
        }

        public void PrintContents()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(myItems[i]);
            }
        }



        // Hold useful items
        // Hotbar to hold items that could be useful at some point in the game
        // Groups items together (multiple of one item, or related items)
        // Features that sort the backpack
        // Key items that track progression
        // Items of different groups (consumable, weapons, etc.)
        // Carrying capacity/weight
        // Upgrade in size
        // Retrieve info about items (durability, special properties, etc.)
        // Swap equipped items (shovel to fishing pole to ladder/etc.)
        // Put stuff inside

        // ERIN: property that returns the myStuff array
        //       default expression to fill array with starting data
        //       private method vs. public method
        //       throwing exceptions
        //       make class generic
        //       write indexer
        //       write indexer with variables (not ideal but ok to show for now)
    }
}
