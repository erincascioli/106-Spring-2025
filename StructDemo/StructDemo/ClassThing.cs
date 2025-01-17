using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class ClassThing
    {
        // Contains some type of data
        private string word;
        private int number;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // Will compile, even if each field isn't assigned a value
        // Uses that data type's default value
        public ClassThing(string word)
        {
            this.word = word;
            this.number = 0;
        }

        public ClassThing()
        {
            this.word = "mug";
            this.number = 1000;
        }

        public void PrintInformation()
        {
            Console.WriteLine("The word is " + word);
            Console.WriteLine("The number is " + number);
        }
    }
}
