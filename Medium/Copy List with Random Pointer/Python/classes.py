from typing import Optional


class Node:
	def __init__(self, x: int, next: Optional['Node'] = None, random: Optional['Node'] = None):
		self.val = int(x)
		self.next = next
		self.random = random

	def __str__(self) -> str:
		out: list[str] = []
		node: Optional[Node] = self

		while node is not None:
				out.append(str(node.val))
				node = node.next

		return ", ".join(out)

	def __repr__(self) -> str:
		return str(self)
