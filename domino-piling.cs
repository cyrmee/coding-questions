internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int result = DominoPiling(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(result);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static int DominoPiling(int m, int n)
    {
        if (!(1 <= m && m < 16 && 1 <= n && n < 16 && m <= n))
            throw new Exception("Check your board!");
        return m * n / 2;
    }
}
