using System;

namespace Add_Two_Numbers;

public class Solution {
	public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2) {
		ListNode tot = new(), curr = tot;

		while (l1 != null || l2 != null || curr.val > 9) {
			int n1 = 0, n2 = 0;
			if (l1 != null) {
				n1 = l1.val;
				l1 = l1.next;
			}
			if (l2 != null) {
				n2 = l2.val;
				l2 = l2.next;
			}
			
			int carry = curr.val / 10;
			curr.val %= 10;
			curr.next = new(carry + n1 + n2);
			curr = curr.next;
		}

		return tot.next!;		
	}
}
