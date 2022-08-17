public class Solution {
   public int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            HashSet<string> s = new HashSet<string>();
            foreach (var word in words)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in word)
                    sb.Append(morse[(int)c % 32 - 1]);
                s.Add(sb.ToString());
            }
            return s.Count;
        }
}