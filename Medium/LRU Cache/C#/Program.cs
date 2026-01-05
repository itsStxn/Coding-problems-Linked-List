using LRU_Cache;


void Print(LRUCache obj) {
	Console.WriteLine($"Head = [{obj.Head}], Tail = [{obj.Tail}], Capacity = [{obj.Capacity}] Cache size = [{obj.Cache.Count}]");
	
	Node? curr = obj.Head;
	while (curr != null) {
		Console.WriteLine(curr);
		curr = curr.Next;
	}
	Console.WriteLine();
}


LRUCache lRUCache = new(2);
lRUCache.Put(1, 1); // cache is {1=1}
Print(lRUCache);
lRUCache.Put(2, 2); // cache is {1=1, 2=2}
Print(lRUCache);
Console.WriteLine($"Result: {lRUCache.Get(1)}");    // return 1
Print(lRUCache);
lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
Print(lRUCache);
Console.WriteLine($"Result: {lRUCache.Get(2)}");    // returns -1 (not found)
Print(lRUCache);
lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
Print(lRUCache);
Console.WriteLine($"Result: {lRUCache.Get(1)}");    // return -1 (not found)
Print(lRUCache);
Console.WriteLine($"Result: {lRUCache.Get(3)}");    // return 3
Print(lRUCache);
Console.WriteLine($"Result: {lRUCache.Get(4)}");    // return 4
