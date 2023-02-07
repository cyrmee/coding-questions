public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        var round = new LinkedList<int>(piles);
        var coins = 0;

        while (round.Count > 0)
        {
            round.RemoveLast();
            coins += round.Last.Value;
            round.RemoveLast();
            round.RemoveFirst();
        }

        return coins;
    }
}