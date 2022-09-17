public class Solution {
    public string ConvertToTitle(int columnNumber) {
        if (columnNumber == 0) return "";
        return ConvertToTitle(--columnNumber / 26) + (char)(columnNumber % 26 + 'A');
    }
}