using System;

namespace Copy_List_with_Random_Pointer;

public class Solution {
	public Node? CopyRandomList(Node head) {
		Node? copy = new(0), curr = head;

		while (curr != null) {
			var next = curr.next;
			curr.next = new(curr.val){
				next = next
			};
			curr = next;
		}

		curr = head;
		while (curr != null) {
			var next = curr.next!;
			if (curr.random != null)
				next.random = curr.random.next;
			curr = next.next;
		}

		curr = head; 
		var currCopy = copy;
		while (curr != null) {
			var next = curr.next!;
			currCopy.next = next;
			currCopy = currCopy.next;

			curr.next = next.next;
			curr = next.next;
		}

		return copy.next;
	}

	public Node? CopyRandomListWithDictionary(Node head) {
		Dictionary<Node, Node> randoms = [];
		Node? curr = head, copy = new(0), currCopy = copy;

		while (curr != null) {
			currCopy.next = new(curr.val);
			currCopy = currCopy.next;

			randoms.Add(curr, currCopy);

			currCopy.random = curr.random;
			curr = curr.next;
		}

		currCopy = copy.next;
		while (currCopy != null) {
			if (currCopy.random != null)
				currCopy.random = randoms[currCopy.random];
			currCopy = currCopy.next;
		}

		return copy.next;
	}
}

public class Node {
	public int val;
	public Node? next;
	public Node? random;
	private Node? curr = null;
	private readonly string id = Guid.NewGuid().ToString();
	
	public Node(int[] input) {
		Add(input);
	}

	public Node(int val, Node? next = null, Node? random = null) {
		this.val = val;
		this.next = next;
		this.random = random;
	}
	
	public Node Add(int[] input) {
		if (input.Length > 0) {
			val = input[0];
			for (int i = 1; i < input.Length; i++) {
				Add(input[i]);
			}
		}

		return this;
	}

	public Node Add(int node) {
		curr ??= this;
		curr.next = new Node(node);
		curr = curr.next;
		return this;
	}

	public Node Add(Node? node) {
		curr ??= this;
		curr.next = node;
		curr = curr.next;
		return this;
	}
	
	public override string ToString() {
		var output = new List<string>();
		HashSet<string> visited = [];
		var node = this;

		while (node != null) {
			if (!visited.Add(node.id)) break;

			var rndm = node.random != null ? node.random.val.ToString() : "null";
			output.Add($"[{node.val},{rndm}]");
			node = node.next;
		}

		return string.Join(", ", output);
	}
}
