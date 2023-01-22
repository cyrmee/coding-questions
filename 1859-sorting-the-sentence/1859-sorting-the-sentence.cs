public class Solution {
    public string SortSentence(string s) {
        var listOfWords = s.Split(' ').ToList();
        string sentence = string.Empty;
        var dictionary = new SortedDictionary<int, string>();
        foreach (var item in listOfWords)
            dictionary.Add(Convert.ToInt32(item.Last()), item.Substring(0, item.Length - 1));
        foreach (var item in dictionary)
            sentence += item.Value + " ";
        return sentence.Substring(0, sentence.Length - 1);
    }
}