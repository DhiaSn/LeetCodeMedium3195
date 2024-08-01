namespace LeetCodeMedium3195
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Solution.MinimumArea([[0, 1, 0], [1, 0, 1]]);
            if (result1 != 6)
            {
                Console.WriteLine($"result1 is: {result1} instead of 6");
                return;
            }
            int result2 = Solution.MinimumArea([[1, 0], [0, 0]]);
            if (result2 != 1)
            {
                Console.WriteLine($"result2 is: {result2} instead of 1");
                return;
            }

            Console.WriteLine($"it works perfectly!");
        }
    }
}
