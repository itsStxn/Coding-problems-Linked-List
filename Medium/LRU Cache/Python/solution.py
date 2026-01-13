from typing import Optional
from classes import Node


class LRUCache:
	def __init__(self, capacity: int):
		self.cache: dict[int, Node] = {}
		self.head: Optional[Node] = None
		self.tail: Optional[Node] = None
		self.capacity = capacity

	def get(self, key: int) -> int:
		if key not in self.cache:
			print("returns -1 (not found)")
			return -1
		
		print(f"return {self.cache[key].val}")
		return self.move_to_head(self.cache[key]).val
		
	def put(self, key: int, value: int) -> None:
		if key in self.cache:
			n = self.cache[key]
			n.val = value
			self.move_to_head(n)
		else:
			n = Node(key, value)
			self.cache[key] = n

			if not self.head:
				self.head = self.tail = n
			else:
				self.move_to_head(n)

			if len(self.cache) > self.capacity and self.tail:
				del self.cache[self.tail.key]
				self.tail = self.tail.prev
				if self.tail:
					self.tail.next = None
		self.print_cache()

	def move_to_head(self, n: Node) -> Node:
		if n == self.head:
			return n
		if n == self.tail:
			self.tail = n.prev

		if n.prev:
			n.prev.next = n.next
		if n.next:
			n.next.prev = n.prev

		n.prev = None
		n.next = self.head
		if self.head:
			self.head.prev = n
		self.head = n

		return n

	def print_cache(self) -> None:
		curr = self.head
		out = []

		while curr:
			out.append(f"{curr.key}={curr.val}")
			curr = curr.next

		print("cache is {" + ", ".join(out) + "}")
