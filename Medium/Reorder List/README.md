# Reorder List

## Description
You are given the head of a singly linked-list. The list can be represented as:

`L0 → L1 → … → Ln - 1 → Ln`  
Reorder the list to be on the following form:

`L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …`  
You may not modify the values in the list's nodes. Only nodes themselves may be changed.

### Example 1
**Input**: head = [1,2,3,4]  
**Output**: [1,4,2,3]

### Example 2
**Input**: head = [1,2,3,4,5]  
**Output**: [1,5,2,4,3]

### Constraints
The number of nodes in the list is in the range `[1, 5 * 10^4]`.  
1 <= `Node.val` <= 1000

## Strategy
Use `slow` and `fast` pointers to split the list in 2 halves: make `slow` advance by 1 node and `fast` by 2. When `fast` reaches the end, `slow` will be the middle node.

The middle node is the last node of the first half. Store the second half in `second`, then remove the second half from the first one and store it in `first`.

Finally, take `first` and `second` and merge them alternetively.

## Time Complexity - O(n)
All the loops process nodes once.

## Space Complexity - O(1)
No data structure variables with `n` size are used.
