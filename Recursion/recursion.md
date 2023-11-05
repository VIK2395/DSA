- Base case
- Recursive case

Types of recursion:

- __Direct recursion__ (also called mutual recursion) / __Indirect recursion__ (when a function is called not by itself but by another function that it called by the recursive function);
- General / Head / Tail recursion (recursive functions that don't fit neatly into the categories of head or tail recursion are typically referred to as "non-tail recursion" or "general recursion");
- Liner / Tree recursion;
- Nested recursion;

If the target of a tail is the same subroutine, the subroutine is said to be __tail recursive, which is a special case of direct recursion__.\
Source https://en.wikipedia.org/wiki/Tail_call

Traditional vs Tail\
https://www.quora.com/What-is-the-difference-between-normal-recursion-and-tail-recursion-with-examples\
https://www.pixelstech.net/article/1474689232-Traditional-recursion-vs-Tail-recursion#:~:text=In%20simple%2C%20the%20main%20difference,recursion%20call%20in%20tail%20recursion\
https://www.youtube.com/watch?v=XMBgja5u70M

https://www.youtube.com/watch?v=l3qIbfuAhCw \
https://www.geeksforgeeks.org/types-of-recursions/ \
https://stackoverflow.com/questions/33923/what-is-tail-recursion

__Not all recursions can be made tail-recursive.__ https://www.youtube.com/watch?v=XMBgja5u70M 4:55\
__Tail recursion implemantation can always be re-written in a loop manner.__ https://www.youtube.com/watch?v=l3qIbfuAhCw \
__In tail recursion, we accumulate result in a parameter/argument and pass it across the calls.__\
It works as a reducer func in JavaScript.

In some programmming languages, while compiling __Tail-call optimization or tail-call elimination__ is performed(i.e. final code uses GOTO/JUMP instructions over a tail-recursive method, which is equivalent to an iterative loop implementation)

=================================================================\
__Recursion Auxiliary space complexity:__\
https://www.geeksforgeeks.org/auxiliary-space-recursive-functions \
https://algodaily.com/lessons/understanding-space-complexity

__Recurrence Relations__ https://www.geeksforgeeks.org/how-to-solve-time-complexity-recurrence-relations-using-recursion-tree-method/
=================================================================\
