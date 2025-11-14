using System;

namespace Linked_List_Cycle;

public class Solution {
	public bool HasCycle(ListNode head) {
		ListNode? slow = head, fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next;
			fast = fast.next.next;
			if (slow == fast) return true;
		}

		return false;
	}
	public bool HasCycleDisruptive(ListNode head) {
		ListNode? marker = new(), curr = head.next;

		while (curr != null) {
			if (curr == marker) return true;
			var next = curr.next;
			curr.next = marker;
			curr = next;
		}

		return false;
	}
}

public class ListNode {
	public int val;
	public ListNode? next;
	private ListNode? curr = null;
	private readonly string id = Guid.NewGuid().ToString();
	
	public ListNode(int[] input) {
		Add(input);
	}

	public ListNode(int val = 0, ListNode? next = null) {
		this.val = val;
		this.next = next;
	}
	
	public ListNode Add(int[] input) {
		if (input.Length > 0) {
			val = input[0];
			for (int i = 1; i < input.Length; i++) {
				Add(input[i]);
			}
		}

		return this;
	}

	public ListNode Add(int node) {
		curr ??= this;
		curr.next = new ListNode(node);
		curr = curr.next;
		return this;
	}

	public ListNode Add(ListNode? node) {
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
