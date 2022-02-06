# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def mergeTwoLists(self, list1, list2):
        current = head = ListNode(0) #head node is declared here. the head never iterates, so we use the head to return the whole list
        print('n.val')
        print (head.val)
        print('n.val.next')
        while list1 and list2:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next 
            else:
                current.next = list2
                list2 = list2.next
            current = current.next
        current.next = list1 or list2
        print('n.val')
        print (head.val)
        print('n.val.next')
        print (head.next.val)
        return head.next


l1 = ListNode(1)
l1.next = ListNode(1)
l1.next.next = ListNode(2)
l2 = ListNode(3)
l2.next = ListNode(4)
l2.next.next = ListNode(6)

solution = Solution()
l3 = solution.mergeTwoLists(l1,l2)

# print (l3.val)
# while l3.next:
#     print(l3.next.val)
#     l3 = l3.next
