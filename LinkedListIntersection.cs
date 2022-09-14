public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode A = headA;
        ListNode B = headB;
        while (A != B) {
            if (A == null) A = headB;
            else A = A.next;
            if (B == null) B = headA;
            else B = B.next;
        }
        return B;
    }
}