namespace Assessment1
{
    public class SumOfMultiples
    {
        public static int Until(int limit) => Until(3, 5, limit);

        private static int Until(int a, int b, int limit)
        {
            int n = (limit - 1) / (a * b);

            return a * b * n * (n + 1) / 2;
        }
    }
}
