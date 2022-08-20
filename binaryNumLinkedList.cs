public class Solution {
    public int GetDecimalValue(ListNode head) {
        int n = head.val;
        
        while (head.next != null) {
            n = (n << 1) | head.next.val;
            head = head.next;
        }
        return n;
    }
}