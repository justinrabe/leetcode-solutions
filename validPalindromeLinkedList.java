class Solution {
    public boolean isPalindrome(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        ListNode reversed;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        reversed = slow;
        slow = slow.next;
        reversed.next = null;
        while (slow != null) {
            ListNode nx = slow.next;
            slow.next = reversed;
            reversed = slow;
            slow = nx;
        }
        
        while (reversed != null) {
            if (reversed.val != head.val) return false;
            reversed = reversed.next;
            head = head.next;
        }
        return true;
    }
}