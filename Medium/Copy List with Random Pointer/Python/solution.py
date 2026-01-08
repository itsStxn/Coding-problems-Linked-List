from typing import Optional
from classes import Node


class Solution:
	def copyRandomList(self, head: Optional[Node]) -> Optional[Node]:
		if head is None:
			return head

		curr = head
		while curr is not None:
			copy_node = Node(x=curr.val, next=curr.next, random=curr.random)
			curr.next = copy_node
			curr = copy_node.next

		curr = head
		while curr and curr.next:
			if curr.random:
				curr.next.random = curr.random.next
			curr = curr.next.next

		copy = Node(x=0)
		curr, curr_copy = head, copy
		while curr and curr.next and curr_copy:
			curr_copy.next = curr.next
			curr.next = curr.next.next
			curr = curr.next
			curr_copy = curr_copy.next

		return copy.next
