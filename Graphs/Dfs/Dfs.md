Depth-first search(DFS) is a __recursive__ algorithm that uses the backtracking principle.\
__So, any recursion is always Dfs.__ Traverse branch by branch; has recursive and loop implementations(with sctack).\
Algorithm for traversing or searching tree or graph data structures.\
Time Complexity O(vertices + edges);

Has 3 three traversal approaches:
- Pre-order https://leetcode.com/problems/binary-tree-preorder-traversal/?envType=list&envId=ob9rj7ig;
- In-order https://leetcode.com/problems/binary-tree-inorder-traversal/?envType=list&envId=ob9rj7ig;
- Post-order https://leetcode.com/problems/binary-tree-postorder-traversal/?envType=list&envId=ob9rj7ig;

About traversal strategies:\
https://www.geeksforgeeks.org/dfs-traversal-of-a-tree-using-recursion \
*Here backtracking is used for traversal. In this traversal first, the deepest node is visited and then backtracks to its parent node\
if no sibling of that node exists*.\
https://www.enjoyalgorithms.com/blog/binary-tree-traversals-preorder-inorder-postorder

Algorithm for graphs:\
https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/

https://www.geeksforgeeks.org/why-is-the-complexity-of-both-bfs-and-dfs-ove/ \
Graph might have two different disconnected parts so to make sure that we cover every vertex, we run DFS algorithm on every node.
The outer loop will be executed V times and inner loop will be executed E times exactly once. Thus, Time Complexity O(V+E).
Auxiliary Space Complexity O(2*V) = O(V). In worst case recursive stack height will be filled with all vertices(liner graph), plus extra array/set to keep track of visited verticles.
