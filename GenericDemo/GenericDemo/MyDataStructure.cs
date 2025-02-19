using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
	/// <summary>
	/// A structure for holding some data (and mostly
	/// demoing generics)
	/// </summary>
	/// <typeparam name="A">The type of data to hold</typeparam>
	class MyDataStructure<A>
	{
		// Fields for the data we want to hold, and any
		// other important meta data
		private A[] data;               // The "stuff" in my structure
		private int count;              // Count is always an int!
        private A someValue;            // Testing the default expression


        // NOOOOOOOOOOOOOOOOOOOOO
        // This is bad!
        /*
        public A[] Data
        {
            get { return data; }
            set { data = value; }
        }
        */


       /// <summary>
       /// Indexer returns data from the array
       /// </summary>
       /// <param name="index">Index to retrieve or modify</param>
       /// <returns>Data at specified index</returns>
       /// <exception cref="Exception">Index out of range exception thrown upon invalid index</exception>
        public A this[int index]
        {
            get
            {
                // Error check! Make sure index is valid. If not, throw an exception.
                if(index < 0 || index >= count)
                {
                    throw new Exception("OH NO BAD INDEX!");
                }

                return data[index];
            }

            set
            {
                // Error check! Make sure index is valid. If not, throw an exception.
                if (index < 0 || index >= count)
                {
                    throw new Exception("OH NO BAD INDEX!");
                }

                data[index] = value;
            }
        }


		/// <summary>
		/// Gets the count of the list
		/// </summary>
		public int Count { get { return count; } }


        /// <summary>
        /// Creates a new data structure with an internal capacity of 4
        /// </summary>
        public MyDataStructure()
		{
			// Initialize the array
			data = new A[4];
            count = 0;
            FillData();

            // Test the default expression
            someValue = default(A);
		}


        /// <summary>
        /// Fills the underlying array with default data of type T
        /// </summary>
        private void FillData()
        {
            // Fill the array with starting data
            for(int i = 0; i < 4; i++)
            {
                data[i] = default(A);
            }
        }


        /// <summary>
        /// This adds an item to the data structure, provided enough room.
        /// </summary>
        /// <param name="item">The data to add to the structure</param>
        public void Add(A item)
		{
			// Error checking here would be ideal!
			data[count] = item;
			count++;
		}


        /// <summary>
        /// Retrieves a specific index from this data structure
        /// </summary>
        /// <param name="index">Index of data to retrieve</param>
        /// <returns>The data at that index in the underlying array</returns>
        public A GetData(int index)
        {
            // Invalid indices:
            if(index < 0 || index >= count)
            {
                // Choose to throw an exception
                // Or I could do nothing
                // Or I could insert data at a valid index instead
                // Or I could use Abs()
            }

            // Passed the invalid index check:
            return data[index];
        }
	}
}
