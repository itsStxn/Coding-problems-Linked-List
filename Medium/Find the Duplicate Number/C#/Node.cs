using System;

namespace Find_the_Duplicate_Number;

public class Node(int val = 0, Node? prev = null, Node? next = null) {
	public int Val = val;
	public Node? Prev = prev;
	public Node? Next = next;

	public override string ToString() {
		var output = new List<int>();
		HashSet<string> visited = [];
		var curr = this;

		while (curr != null) {
			output.Add(curr.Val);
			curr = curr.Next;
		}

		return string.Join(", ", output);
	}
}
