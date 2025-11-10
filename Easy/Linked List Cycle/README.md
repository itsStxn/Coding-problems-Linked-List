# Linked List Cycle

## Description
Given `head`, the `head` of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, `pos` is used to denote the index of the node that tail's next pointer is connected to. 

**Note that `pos` is not passed as a parameter.**

Return true if there is a cycle in the linked list. Otherwise, return false.

### Example 1
**Input**: `head` = [3,2,0,-4], `pos` = 1  
**Output**: true  
**Explanation**: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).

### Example 2
**Input**: `head` = [1,2], `pos` = 0    
**Output**: true  
**Explanation**: There is a cycle in the linked list, where the tail connects to the 0th node.

### Example 3
**Input**: `head` = [1], `pos` = -1    
**Output**: false  
**Explanation**: There is no cycle in the linked list.

### Constraints
The number of the nodes in the list is in the range `[0, 104]`  
-105 <= `Node.val` <= 105  
`pos` is -1 or a valid index in the linked-list.

*Follow up: Can you solve it using O(1) (i.e. constant) memory?*

## Strategy
### Floyds Tortoise algorithm
Set a `fast` and `slow` pointers.

`slow` moves by 1 node, `fast` moves by 2 nodes. Eventually, `fast` will be exactly equal to `slow` because they point to the same reference.

### Disruptive approach
Set a `curr` and `marker` pointers.

`curr` moves forward, and every node found by it becomes `marker`. If `curr` finds `marker`, it means that it has already seen that node, thus running in a cycle. The method is not recommended because it alters `head`, making it lose all of its references.

## Time Complexity - O(n)
Each node is processed either once or slightly more than once at worst.

## Space Complexity - O(1)
The variables only store pointers.
