using System;

namespace Linked_List_Cycle;

public class Solution {
	public bool HasCycle(ListNode head) {
		return default;
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
