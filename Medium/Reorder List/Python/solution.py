from typing import Optional, cast
from classes import ListNode

class Solution:
	def reorderList(self, head: Optional[ListNode]) -> None:
		"""
		Do not return anything, modify head in-place instead.
		"""

		if head is None or head.next is None:
			return
	
		slow, fast = head, head
		while fast is not None and fast.next is not None:
			fast = fast.next.next
			slow = cast(ListNode, slow.next)

		second = self.reverseList(slow.next)
		slow.next = None
		first = head

		while first is not None and second is not None:
			tmp1 = first.next
			tmp2 = second.next

			first.next = second
			second.next = tmp1

			first = tmp1
			second = tmp2

	def reverseList(self, head: Optional[ListNode]) -> ListNode:
		curr, reverse = head, None
		
		while curr is not None:
			next_node = curr.next
			curr.next = reverse
			reverse = curr
			curr = next_node

		return cast(ListNode, reverse)
