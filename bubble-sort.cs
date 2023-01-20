using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        countSwaps(a);
    }

    public static void countSwaps(List<int> a)
    {
        int counter = 0;
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count - 1; j++)
            { 
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp; 
                    counter++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {counter} swaps.  \r\nFirst Element: {a[0]}  \r\nLast Element: {a[a.Count - 1]} ");
    }
}
