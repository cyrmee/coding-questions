public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> array = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                array.Add("FizzBuzz");
            else if (i % 3 == 0)
                array.Add("Fizz");
            else if (i % 5 == 0)
                array.Add("Buzz");
            else array.Add(i.ToString());
        }
        return array;
    }
}