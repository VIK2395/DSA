Types of recursion:

- (Traditional) __Direct recursion__ (also called mutual recursion) / __Indirect recursion__ (when a function is called not by itself but by another function that it called by the recursive function);
- Head / Tail recursion;
- Liner / Tree recursion;
- Nested recursion;

https://en.wikipedia.org/wiki/Tail_call \
https://www.youtube.com/watch?v=l3qIbfuAhCw \
https://www.geeksforgeeks.org/types-of-recursions/ \
https://stackoverflow.com/questions/33923/what-is-tail-recursion

__Tail recursion implemantation can always be re-written in a loop manner.__

In some programmming languages, while compiling __Tail-call optimization or tail-call elimination__ is performed(i.e. final code uses GOTO/JUMP instructions over a tail-recursive method, which is equivalent to an iterative loop implementation)

- Base case
- Recursive case
  
__In tail recursion, we accumulate result in a parameter/argument and pass it across the calls.__\
It works as a reducer func in JavaScript.
