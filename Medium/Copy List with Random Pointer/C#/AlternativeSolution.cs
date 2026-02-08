using System;

namespace Copy_List_with_Random_Pointer;

public class AlternativeSolution : Solution {
	override public Node? CopyRandomList(Node head) {
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
