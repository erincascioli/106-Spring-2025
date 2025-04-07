namespace DelegateEvent_Demo_Spring25
{

    public delegate void IDontKnow();
    public delegate int MathOperation(int a, int b);   // <-- Method signature of Add, Subtract, and Multiply
    public delegate void WhateverAgain(string s);
    public delegate int[] WhateverAgainAgain(float f);

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation myOperationVariable = Multiply;

            int result = myOperationVariable(4, 7);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Whatever()
        {
            Console.WriteLine("Whatever");
        }
    }
}
