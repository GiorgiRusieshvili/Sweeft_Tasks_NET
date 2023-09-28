namespace assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "kayak";
            Console.WriteLine(IsPalindrome(text));

        }

        //method checks if a given input is a palindrome and returns boolean value
        static bool IsPalindrome(string input)
        {

            string UpperCaseInput = input.ToUpper();
            var ToChar = UpperCaseInput.ToCharArray();
            Array.Reverse(ToChar);

            for (int i = 0; i < UpperCaseInput.Length; i++)
            {
                if (UpperCaseInput[i] != ToChar[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}