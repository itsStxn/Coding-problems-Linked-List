from typing import Optional, cast
from classes import ListNode


class Solution:
	def hasCycle(self, head: Optional[ListNode]) -> bool:
		if not head or not head.next:
			return False

		slow, fast = head, head
		while fast is not None and fast.next is not None:
			slow = cast(ListNode, slow).next
			fast = fast.next.next
			if slow == fast:
				return True

		return False
