public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null) return null;
        ListNode curr = head;
        ListNode newHead = head;
        int len = 1;
        while (curr.next != null) {
            curr = curr.next;
            len++;
        } 
        curr.next = head;
        k %= len; 
        for(int i=0; i<len-k; i++) curr = curr.next; 
        newHead = curr.next; 
        curr.next = null;
        return newHead;
    }
}