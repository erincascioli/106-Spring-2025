using System;

namespace RecursionDemo
{
    internal class Program
    {
        public static int SomeNumber
        {
            get { return 5; }
        }

        static void Main(string[] args)
        {
            //int value = SomeNumber;
            int[] numbers = { 5, 10, 15, 20, 25, 35, 35 };
            SumRecursivelyEveryThird(numbers, 2);
        }

        static int SumRecursivelyEveryThird(int[] array, int index)
        { 
            if (index >= array.Length) 
                return 0; 
    
            return 
                array[index] + 
                SumRecursivelyEveryThird(array, index + 3); 
        }
    }
}
