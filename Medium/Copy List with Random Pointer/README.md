# Copy List with Random Pointer

## Description
A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or `null`.

Construct a [deep copy](https://en.wikipedia.org/wiki/Object_copying#Deep_copy) of the list. The deep copy should consist of exactly n brand new nodes, where each new node has its value set to the value of its corresponding original node. Both the next and random pointer of the new nodes should point to new nodes in the copied list such that the pointers in the original list and copied list represent the same list state. **None of the pointers in the new list should point to nodes in the original list**.

For example, if there are two nodes `X` and `Y` in the original list, where `X.random --> Y`, then for the corresponding two nodes `x` and `y` in the copied list, `x.random --> y`.

Return the *head of the copied linked list*.

The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of `[val, random_index]` where:
- `val`: an integer representing `Node.val`
- `random_index`: the index of the node (range from `0` to `n-1`) that the `random` pointer points to, or `null` if it does not point to any node.

Your code will **only** be given the `head` of the original linked list.

### Example 1
**Input**: `head` = [[7,null],[13,0],[11,4],[10,2],[1,0]]  
**Output**: [[7,null],[13,0],[11,4],[10,2],[1,0]]  

### Example 2
**Input**: `head` = [[1,1],[2,1]]  
**Output**: [[1,1],[2,1]]  

### Example 3
**Input**: `head` = [[3,null],[3,0],[3,null]]  
**Output**: [[3,null],[3,0],[3,null]]  

### Constraints
- 0 <= `n` <= 1000
- -10^4 <=` Node.val` <= 10^4
- `Node.random` is `null` or is pointing to some node in the linked list.

## Strategy
### With Dictionary
Create a dictionary that has both key and value of type node. Move through `head`, create new nodes with same value and `random` to add to `copy`, and store each original node as a key to the newly created copy. in the dictionary. Then move through `copy` and replace each `random` pointer with its copy by indexing the dictionary with `random` itself.

### Without Dictionary
Move through `head` and store a copy of each node as the next node of the original `(A => A' => B => B' => C => C' => ...)`. Then move again through `head` and set the `random` pointer of each copied node as the node next to the `random` pointer of its original counterpart. Move through `head` a final time to move the copied values to `copy`. 

## Time Complexity - O(n)
All the list trasversals process each node once.

## Space Complexity - O(1) and O(n)
### With Dictionary
The dictionary stores n elements.

### Without Dictionary
There are no variables of n size.
