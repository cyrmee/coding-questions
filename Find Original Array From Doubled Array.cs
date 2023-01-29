public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        if (changed.Length % 2 == 1 || changed.Length == 0) return Array.Empty<int>();

        Array.Sort(changed);

        var original = new List<int>();
        var result = new LinkedList<int>(changed);

        for (int i = 0; i < changed.Length; i++)
        {
            if (result.Contains(changed[i]) && result.Contains(changed[i] * 2))
            {
                result.Remove(changed[i]);
                result.Remove(changed[i] * 2);
                original.Add(changed[i]);
            }
        }

        if (result.Count == 0)
            return original.ToArray();
        else return Array.Empty<int>();
    }
}
