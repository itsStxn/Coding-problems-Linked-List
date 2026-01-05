using System;

namespace LRU_Cache;

public class Node {
	public int Key;
	public int Value;
	public Node? Prev;
	public Node? Next;

	public Node(int key, int value, Node? prev = null, Node? next = null) {
		Key = key;
		Value = value;
		Prev = prev;
		Next = next;
	}

	public override string ToString() {
		return $"Key: {Key}, Value: {Value}";
	}
}
