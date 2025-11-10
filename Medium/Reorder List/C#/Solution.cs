using System;

namespace Reorder_List;

public class Solution {
	public void ReorderList(ListNode head) {
		ListNode slow = head, fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next!;
			fast = fast.next.next!;
		}

		ListNode? first = head, second = ReverseList(slow)!;
		while (second != null) {
			ListNode? temp1 = first.next;
			ListNode? temp2 = second.next;

			first.next = second;
			second.next = temp1;

			first = temp1!;
			second = temp2;
		}

	}

	private ListNode? ReverseList(ListNode head) {
		ListNode? prev = null,  curr = head.next;
		head.next = null;

		while (curr != null) {
			var next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}

		return prev;
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

