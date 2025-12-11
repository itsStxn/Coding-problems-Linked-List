from typing import Optional
from classes import ListNode 


class Solution:
	def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
		if not list1:
			return list2
		if not list2:
			return list1
		
		merged = ListNode()
		curr = merged

		while list1 != None and list2 != None:
			if list1.val < list2.val:
				curr.next = list1
				list1 = list1.next
			else:
				curr.next = list2
				list2 = list2.next
			curr = curr.next

		curr.next = list1 if list1 else list2

		return merged.next
