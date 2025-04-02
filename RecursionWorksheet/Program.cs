namespace RecursionWorksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine(Enigma(7, 3));
            Console.WriteLine(Enigma(3, 2));
            Console.WriteLine(Enigma(3, 1));

            Console.WriteLine("***********************");
            R(5, 3);

            Console.WriteLine("***********************");
            Console.WriteLine(Puzzle(14, 10));
            Console.WriteLine(Puzzle(4, 7));
            Console.WriteLine(Puzzle(0, 0));
        }

        public static int Enigma(int x, int y)
        {
            if(y == 1)
            {
                return x;
            }
            else
            {
                return x + Enigma(x, y - 1);
            }
        }

        public static void R(int x, int y)
        {
            if(y > 0)
            {
                R(x + 1, y - 1);
                Console.WriteLine(x + " " + y);
            }
        }

        public static int Puzzle(int baseB, int limit)
        {
            if(baseB > limit)
            {
                return -1;
            }
            else if(baseB == limit)
            {
                return 1;
            }
            else
            {
                return baseB * Puzzle(baseB + 1, limit);
            }
        }
    }
}
