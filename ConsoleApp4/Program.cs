namespace MagicNumberLuca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"MagicNumber of {i} = {MagicNumber(i)}");

            }
            // MagicNumberLinear(10);
            //      Console.WriteLine($"MagicNumber of 100_000 = {MagicNumber(100_000)}");
            MagicNumberLinear(100_000);

        }

        static int MagicNumber(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            var a = MagicNumber(n - 1) + 2 * n;
            return a;
        }
        static int MagicNumberLinear(int value)
        {
            var result = 0;


            for (int n = 0; n <= value; n++)
            {
                result = result + (2 * n);

                if (result < 0) result = 0;

                Console.WriteLine($"MagicNumber of {n} = {result}");
            }
            return result;
        }



    }
}