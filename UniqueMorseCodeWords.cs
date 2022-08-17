public class Solution {
   public int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            HashSet<string> s = new HashSet<string>();
            foreach (var word in words)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in word)
                {
                    int index = (int)c % 32 - 1;
                    sb.Append(morse[index]);
                }
                s.Add(sb.ToString());
            }
            return s.Count;
        }
}