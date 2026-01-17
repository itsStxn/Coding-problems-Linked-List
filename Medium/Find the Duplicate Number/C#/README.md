# Find the Duplicate Number

## Description
Given an array of integers `nums` containing `n + 1` integers where each integer is in the range `[1, n]` inclusive.  
There is only **one repeated number** in `nums`, return this repeated number.  
You must solve the problem **without** modifying the array `nums` and using only constant extra space.

### Example 1
**Input**: nums = [1,3,4,2,2]  
**Output**: 2  

### Example 2
**Input**: nums = [3,1,3,4,2]  
**Output**: 3  

### Example 3
**Input**: nums = [3,3,3,3,3]  
**Output**: 3  

### Constraints
1 <= `n` <= 105  
nums.length == `n + 1`  
1 <= `nums[i]` <= `n`  
All the integers in `nums` appear only once except for precisely one integer which appears **two or more** times.

## Strategy
Treat the array as a linked list where each value determines the next node. Detect a cycle usinf Floyd's Turtle algorithm, then reset the `slow` pointer to the first node, and start moving that and `fast` by 1 node at a time until they meet again. That meeting node is the duplicate.

## Time Complexity - O(n)
Each node is processed once during each loop.

## Space Complexity - Answer
No extra space allocated based on `n`.
