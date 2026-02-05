# Reverse Linked List

## Description
Given the head of a singly linked list, reverse the list, and return the reversed list.

### Example 1
**Input**: `head` = [1,2,3,4,5]  
**Output**: [5,4,3,2,1]

### Example 2
**Input**: `head` = [1,2]  
**Output**: [2,1]

### Example 3
**Input**: `head` = []  
**Output**: []

### Constraints
- The number of nodes in the list is the range `[0, 5000]`.
- -5000 <= `Node.val` <= 5000

*Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?*

## Strategy
Linked lists references can be copied onto different variables. Those copies will stay unaffected by any changes done on the original linked list and its references.

Create a variable `next` to store a copy of the next reference of `head` (moved forward by one node). Append the node `prev` to the next value of `head`. That alters the references of `head` and It'll appear as if it is being reversed node by node. Then store `head` in `prev`. Store `next` inside `head`, so that it regains its original references (but  moved forward by one node). The process stops when `head` is a `null` value.

## Time Complexity - O(n)
Each element in node is processed once.

## Space Complexity - O(1) & O(n)
The iterative approach leverages pointers, thus there's no need for extra space depending on `n`. However, the recursive aproach implements the call stack depending on `n` nodes.
