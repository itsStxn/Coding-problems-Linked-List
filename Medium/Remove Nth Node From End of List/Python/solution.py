from typing import Optional, cast
from classes import ListNode


class Solution:
		def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
			if head is None:
				return head
			
			head = ListNode(next=head)	
			slow, fast = head, head

			for _ in range(n):
				fast = cast(ListNode, fast.next)

			while fast.next is not None:
				fast = fast.next
				slow = cast(ListNode, slow.next)

			slow.next = cast(ListNode, slow.next).next
			return head.next