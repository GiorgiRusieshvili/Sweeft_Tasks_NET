namespace assignment_2
{

    public class Program
    {
        public static void Main(string[] args)
        {
           
            Console.Write("Enter an amount in Georgian Tetri: ");

            var amount = int.Parse(Console.ReadLine());

               var coins =minSplit(amount);

            Console.Write("Your amount " + amount.ToString() + " tetri consists of: ");
            if (coins[0] != 0)
            {
                Console.Write("(" + coins[0].ToString() + " x 50 tetri) , ");
            }
            if (coins[1] != 0)
            {
                Console.Write("(" + coins[1].ToString() + " x 20 tetri) , ");
            }
            if (coins[2] != 0)
            {
                Console.Write("(" + coins[2].ToString() + " x 10 tetri) , ");
            }
            if (coins[3] != 0)
            {
                Console.Write("(" + coins[3].ToString() + " x 5 tetri) , ");
            }
            if (coins[4] != 0)
            {
                Console.Write("(" + coins[4].ToString() + " x 1 tetri)");
            }
        }
        public static int[] minSplit(int amount)
        {
            var money = amount;
            var ans = new int[5];

            var numberOf_50s = (int)(money / 50);
            ans[0] = numberOf_50s;
            money %= 50;
            var numberOf_20s = (int)(money / 20);
            ans[1] = numberOf_20s;
            money %= 20;
            var numberOf_10s = (int)(money / 10);
            ans[2] = numberOf_10s;
            money %= 10;
            var numberOf_5s = (int)(money / 5);
            ans[3] = numberOf_5s;
            money %= 5;
            var numberOf_1s = money;
            ans[4] = numberOf_1s;
            return ans;
        }
    }
}