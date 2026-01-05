using System;

namespace Merge_Two_Sorted_Lists;

public class Solution {
	public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2) {
		ListNode? merged = new(), curr = merged;

		while (list1 != null && list2 != null) {
			if (list1.val < list2.val) {
				curr.next = list1;
				list1 = list1.next;
			}
			else {
				curr.next = list2;
				list2 = list2.next;
			}
			curr = curr.next;
		}

		curr.next = list1 ?? list2;
		return merged.next;
	}
}
