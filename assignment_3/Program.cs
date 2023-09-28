namespace assignment_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 8, 32, -7, 34, 76, 12, -45, -6, 3, 1 };

            Console.WriteLine(NotContains(numbers));
        }





        //this method finds the missing number which is greater than 0 from a given array.
        static int NotContains(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                int num1 = array[i];
                array[i] = 0;

                while (num1 >= 1 && num1 <= n && num1 != array[num1 - 1])
                {
                    int num2 = array[num1 - 1];
                    array[num1 - 1] = num1;
                    num1 = num2;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    return i + 1;
                }

            }
            return n + 1;
        }
    }
}