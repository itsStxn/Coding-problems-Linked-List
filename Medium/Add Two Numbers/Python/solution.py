from typing import Optional
from classes import ListNode


class Solution:
	def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
		tot = ListNode()
		curr = tot

		while l1 or l2 or curr.val > 9:
			n1, n2 = 0, 0
			if l1:
				n1 = l1.val
				l1 = l1.next
			if l2:
				n2 = l2.val
				l2 = l2.next

			carry = curr.val // 10
			curr.val = curr.val % 10
			curr.next = ListNode(n1 + n2 + carry)
			curr = curr.next

		return tot.next
