namespace assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int stairsCount = 6;
            Console.WriteLine(CountVariants(stairsCount));
        }

        static int CountVariants(int stairCount)
        {
            if (stairCount==0 || stairCount==1)
            {
                return 1;
            }
           else { return CountVariants(stairCount - 1) + CountVariants(stairCount - 2); }
        }
    }
}