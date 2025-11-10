# Remove Nth Node From End of List

## Description
Given the head of a linked list, remove the nth node from the end of the list and return its head.

### Example 1
**Input**: `head` = [1,2,3,4,5], `n` = 2  
**Output**: [1,2,3,5]  

### Example 2
**Input**: `head` = [1], `n` = 1  
**Output**: []  

### Example 3
**Input**: `head` = [1,2], `n` = 1  
**Output**: [1]  

### Constraints
The number of nodes in the list is `sz`.  
1 <= `sz` <= 30  
0 <= `Node.val` <= 100  
1 <= `n` <= `sz`

## Strategy
Override `head` so that it starts from a dummy value. Use pointers `slow` and `fast`, and set n distance between them. Then increase them until `fast` is `null`, ad finally update the next reference of `slow` as the node that comes next the latter.

## Time Complexity - O(n)
Each node is processed once.

## Space Complexity - O(1)
The variables only store pointers.
