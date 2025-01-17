using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    struct StructThing
    {
        // Contains some type of data
        private string word;
        private int number;

        // Access the number value outside of this struct
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // MUST assign every field a value, no getting around it
        // Will not compile until you do so
        public StructThing(string word)
        {
            this.word = word;
            this.number = 0;
        }

        public StructThing(int number)
        {
            this.word = "something";
            this.number = number;
        }

        // Structs can have methods, too.
        public void PrintInformation()
        {
            Console.WriteLine("The word is " + word);
            Console.WriteLine("The number is " + number);
        }
    }
}
