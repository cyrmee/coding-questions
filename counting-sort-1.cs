using System.Diagnostics.Metrics;

internal class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = countingSort(arr);

        Console.WriteLine(String.Join(" ", result));
    }

    private static List<int> countingSort(List<int> arr)
    {
        var result = new List<int>();
        var frequencyArray = new List<int>(new int[arr.Max() + 1]);
        for (int i = 0; i < arr.Count; i++)
            frequencyArray[arr[i]]++;
        return frequencyArray;
    }
}
