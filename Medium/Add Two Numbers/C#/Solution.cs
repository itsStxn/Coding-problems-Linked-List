using System;

namespace Add_Two_Numbers;

public class Solution {
	public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2) {
		ListNode res = new(), curr = res;

		int carry = 0;
		while (l1 != null || l2 != null) {
			int sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
			curr.next = new(sum % 10);
			carry = sum / 10;

			curr = curr.next;
			l1 = l1?.next;
			l2 = l2?.next;
		}

		if (carry > 0) 
			curr.next = new(carry);

		return res.next!;		
	}
}
