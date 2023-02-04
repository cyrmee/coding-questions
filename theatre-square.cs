internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(CalculateNumberOfFlagstones(6,6,4));
    }

    public static int CalculateNumberOfFlagstones(int n, int  m, int a)
    {
        var totalArea = n * m;
        var areaFlagstone = a * a;
        var lcm = LCM(totalArea, areaFlagstone);
        return lcm / totalArea;
    }

    public static int LCM(int a, int b)
    {
        int num1, num2;
        if (a > b)
        {
            num1 = a; num2 = b;
        }
        else
        {
            num1 = b; num2 = a;
        }

        for (int i = 1; i < num2; i++)
        {
            int mult = num1 * i;
            if (mult % num2 == 0)
            {
                return mult;
            }
        }
        return num1 * num2;
    }
}
