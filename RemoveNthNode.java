class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
        ListNode l1 = head;
        ListNode l2 = head;
        for (int i = 0; i < n; i++) l1 = l1.next;
        if (l1 == null) return head.next;
        while (l1.next != null) {
            l1 = l1.next;
            l2 = l2.next;
        }
        l2.next = l2.next.next;
        return head;
    }
}