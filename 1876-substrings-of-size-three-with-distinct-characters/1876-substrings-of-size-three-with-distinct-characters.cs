public class Solution {
    public int CountGoodSubstrings(string s) {
       int distinct = 0;
        s = s.ToLower();
        if(1 <= s.Length && s.Length <= 100)
        {
            for (int i = 0; i < s.Length - 2; ++i)
            {
                string subStr = s.Substring(i, 3);
                Console.WriteLine(subStr);
                if (subStr.Length == subStr.Distinct().Count())
                    distinct++;
            }
        }
        return distinct; 
    }
}