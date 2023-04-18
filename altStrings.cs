public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int i = 0;
        int j = 0;
        while (i < word1.Length && j < word2.Length) {
            sb.Append(word1[i++]);
            sb.Append(word2[j++]);
        }
        sb.Append(word1.Substring(i));
        sb.Append(word2.Substring(j));
        return sb.ToString();
    }
}