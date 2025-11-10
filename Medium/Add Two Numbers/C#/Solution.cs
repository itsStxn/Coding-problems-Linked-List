using System;

namespace Add_Two_Numbers;

public class Solution {
	public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2) {
		ListNode res = new(), curr = res;

		int carry = 0;
		while (l1 != null || l2 != null) {
			int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
			curr.next = new(sum % 10);
			carry = sum / 10;

			curr = curr.next;
			l1 = l1?.next;
			l2 = l2?.next;
		}

		if (carry > 0) 
			curr.next = new(carry);

		return res.next!;		
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
