from typing import Optional


class Node:
	def __init__(self, key, val, prev: Optional["Node"] = None, next: Optional["Node"] = None):
		self.key = key
		self.val = val
		self.prev = prev
		self.next = next