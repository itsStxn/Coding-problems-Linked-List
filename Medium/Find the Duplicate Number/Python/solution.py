from typing import List


class Solution:
	def findDuplicate(self, nums: List[int]) -> int:
		slow, fast = nums[0], nums[0]
		do = True

		while do:
			slow = nums[slow]
			fast = nums[nums[fast]]
			do = slow != fast
					
		slow = nums[0]
		while slow != fast:
			slow = nums[slow]
			fast = nums[fast]

		return slow
