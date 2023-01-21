internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        insertionSort1(n, arr);
    }

    public static void insertionSort1(int n, List<int> arr)
    {
        if (1 <= n && n <= 1000)
        {
            int ind = n - 1;
            int e = arr[ind];
            for (int i = ind; i > 0; i--)
            {
                if (e > arr[i - 1])
                {
                    arr[i] = e;
                    printArray(arr);
                    break;
                }
                else
                {
                    arr[i] = arr[i - 1];
                    printArray(arr);
                }
            }
            if (arr[0] == arr[1])
            {
                arr[0] = e;
                printArray(arr);
            }
        }
    }

    public static void printArray(List<int> arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            if (i == arr.Count - 1)
                Console.Write(arr[i]);
            else
                Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
