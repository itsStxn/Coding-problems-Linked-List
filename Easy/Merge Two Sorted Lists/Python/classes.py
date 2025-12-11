from __future__ import annotations
from typing import Optional, Iterable, overload, Any
import uuid


class ListNode:
	@overload
	def __init__(self, val: int = 0,
					next: Optional[ListNode] = None) -> None: ...
	@overload
	def __init__(self, val: Iterable[int],
					next: Optional[ListNode] = None) -> None: ...

	def __init__(self, val: Any = 0,
					next: Optional[ListNode] = None) -> None:

		self.val: int = 0
		self.next: Optional[ListNode] = None
		self._curr: Optional[ListNode] = None
		self._id: str = str(uuid.uuid4())

		if isinstance(val, Iterable) and not isinstance(val, (str, bytes)):
				self.add(val)
		elif isinstance(val, int):
				self.val = val
				self.next = next
		else:
				raise TypeError("val must be int or iterable of int")

	def add(self, arg: int | Iterable[int] | ListNode) -> ListNode:

		if isinstance(arg, Iterable) and not isinstance(arg, (str, bytes)):
				values = list(arg)

				if self._curr is None and self.val == 0 and self.next is None:
					if values:
						self.val = values[0]
					start = 1
				else:
					start = 0

				for v in values[start:]:
					self.add(v)

				return self

		if isinstance(arg, int):
				if self._curr is None:
					self._curr = self

				node = ListNode(arg)
				self._curr.next = node
				self._curr = node
				return self

		if isinstance(arg, ListNode):
				if self._curr is None:
					self._curr = self

				self._curr.next = arg
				self._curr = arg
				return self

		raise TypeError("Unsupported argument type for add()")

	def __str__(self) -> str:
		out: list[str] = []
		visited: set[str] = set()
		node: Optional[ListNode] = self

		while node is not None:
				if node._id in visited:
					break
				visited.add(node._id)
				out.append(str(node.val))
				node = node.next

		return ", ".join(out)

	def __repr__(self) -> str:
		return str(self)
