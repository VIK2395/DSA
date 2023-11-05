Types of recursion:

- Direct recursion (also called mutual recursion);
- Indirect recursion (when a function is called not by itself but by another function that it called by the recursive function);
- Head recursion;
- Tail recursion;

https://en.wikipedia.org/wiki/Tail_call \
https://www.youtube.com/watch?v=l3qIbfuAhCw

__Tail recursion implemantation can always be re-written in a loop manner.__

In some programmming languages, while compiling __Tail-call optimization or tail-call elimination__ is performed(i.e. final code uses GOTO/JUMP instructions over a tail-recursive method, which is equivalent to an iterative loop implementation)

- Base case
- Recursive case
  
