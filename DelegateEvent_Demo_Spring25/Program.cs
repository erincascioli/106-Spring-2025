namespace DelegateEvent_Demo_Spring25
{
    internal class Program
    {
        //public delegate T Something();
        public delegate void IDontKnow();
        public delegate int MathOperation(int a, int b);   // <-- Method signature of Add, Subtract, and Multiply

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MathOperation someMethodWillRun;
            someMethodWillRun = Subtract;
            int result = someMethodWillRun(5, 10);

            IDontKnow someOtherMethod;
            someOtherMethod = Whatever;
            someOtherMethod();
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
