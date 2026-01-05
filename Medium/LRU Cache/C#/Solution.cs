using System;

namespace LRU_Cache;

public class LRUCache {
	public Dictionary<int, Node> Cache;
	public int Capacity;
	public Node? Head;
	public Node? Tail;

	public LRUCache(int capacity) {
		Capacity = capacity;
		Cache = [];
	}
	
	public void MoveToHead(Node n) {
		if (n == Head) return;
		if (n == Tail)
			Tail = Tail.Prev;

		n.Prev?.Next = n.Next;
		n.Next?.Prev = n.Prev;

		n.Prev = null;
		n.Next = Head;
		Head!.Prev = n;
		Head = n;
	}

	public int Get(int key) {
		if (Cache.TryGetValue(key, out var n)) {
			MoveToHead(n);
			return n.Value;
		}
		return -1;
	}
	
	public void Put(int key, int value) {
		if (Cache.TryGetValue(key, out var n)) {
			n.Value = value;
			MoveToHead(n);
		}
		else {
			n = new(key, value);
			Cache.Add(key, n);

			if (Tail == null) {
				Head = n;
				Tail = n;
			}

			MoveToHead(n);
			if (Cache.Count > Capacity) {
				Cache.Remove(Tail.Key);
				Tail = Tail.Prev;
				Tail?.Next = null;
			}
		}
	}
}
