using System;

namespace Remove_Nth_Node_From_End_of_List;

public class Solution {
	public ListNode? RemoveNthFromEnd(ListNode? head, int n) {
		head = new(0, head);
		ListNode? slow = head, fast = head;

		for (int i = 0; i <= n; i++) {
			fast = fast.next!;
		}

		while (fast != null) {
			slow = slow.next!;
			fast = fast.next;
		}

		slow.next = slow.next?.next;

		return head.next;
	}
}

public class ListNode {
	public int val;
	public ListNode? next;
	private ListNode? curr = null;
	private readonly string id = Guid.NewGuid().ToString();
	
	public ListNode(int val = 0, ListNode? next = null) {
		this.val = val;
		this.next = next;
	}
	
	public ListNode Add(int node) {
		curr ??= this;
		curr.next = new ListNode(node);
		curr = curr.next;
		return this;
	}

	public ListNode Add(ListNode node) {
		curr ??= this;
		curr.next = node;
		curr = curr.next;
		return this;
	}
	
	public override string ToString() {
		var output = new List<int>();
		HashSet<string> visited = [];
		var node = this;

		while (node != null) {
			if (!visited.Add(node.id)) break;
			output.Add(node.val);
			node = node.next;
		}

		return string.Join(", ", output);
	}
}
