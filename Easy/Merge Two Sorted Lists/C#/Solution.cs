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

public class ListNode {
	public int val;
	public ListNode? next;
	private ListNode? curr = null;
	
	public ListNode(int val=0, ListNode? next =null) {
		this.val = val;
		this.next = next;
	}
	
	public ListNode Add(int node) {
		curr ??= this;
		curr.next = new ListNode(node);
		curr = curr.next;
		return this;
	}
	
	public override string ToString() {
		var output = new List<int>();
		var iter = this;

		while (iter != null) {
			output.Add(iter.val);
			iter = iter.next;
		}

		return string.Join(", ", output);
	}
}
