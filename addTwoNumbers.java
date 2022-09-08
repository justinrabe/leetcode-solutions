class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode ret = new ListNode(0);
        ListNode curr = ret;
        boolean carry = false;
        while (l1 != null || l2 != null || carry) {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            int val = x + y;
            if (carry) {
                val++;
                carry = false;
            }
            if (val >= 10) {
                val = val - 10;
                carry = true;
            }
            curr.next = new ListNode(val);;
            curr = curr.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return ret.next;
    }
}