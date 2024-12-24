# F# Mutable Variable Swapping Bug

This repository demonstrates a common error in F# related to mutable variables and scope.

## Bug Description
The code attempts to swap two mutable variables using a function. However, due to the way mutable variables are handled in F#, the swap function does not modify the original variables.

## How to Reproduce
1. Clone the repository.
2. Compile and run the `bug.fs` file.
3. Observe that the output shows the original values of x and y, not the swapped values.

## Solution
The solution involves using tuples or returning a new pair of values from the swap function instead of modifying the variables in place.

## Solution Code
The `bugSolution.fs` file contains the corrected code. 