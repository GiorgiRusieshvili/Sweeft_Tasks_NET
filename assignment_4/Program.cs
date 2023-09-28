namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sequence = "(())";

            Console.WriteLine(IsProperly(sequence));
        }

        static bool IsProperly(string sequence)
        {
            Stack<Char> stack = new Stack<Char>();

            for (int i = 0; i < sequence.Length; i++)
            {
                char c = sequence[i];

                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else if (c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    return false;

                }

            }
            return stack.Count == 0;
        }

    }
}
    