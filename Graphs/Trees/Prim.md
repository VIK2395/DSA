Prim’s Algorithm for Minimum Spanning Tree(MST)

https://www.geeksforgeeks.org/prims-minimum-spanning-tree-mst-greedy-algo-5 \
https://en.wikipedia.org/wiki/Prim%27s_algorithm

- A greedy algorithm that finds a __minimum spanning tree__ for a __weighted undirected connected graph__. Works with __both positive and negative edges__.
  It is important to note that both Prim's and Kruskal's algorithms are not suitable for graphs with negative cycles, as they cannot find a spanning tree for such graphs (ChatGPT).
  __Works with cycles__.

https://www.youtube.com/watch?v=f7JOBJIC-NA \
LeetCode: https://leetcode.com/problems/min-cost-to-connect-all-points/?envType=list&envId=ob9rj7ig

Idea uder the hood:\
https://www.programiz.com/dsa/prim-algorithm
1. Select a random vertex and add it to the result tree, it's cost is 0;
2. Mark the vertex as visited; Expand all the tree (not visited) neighbor vertices (connected with edges) and calc their costs;
3. Select the minimun cost neighbor vertex and add it to the tree (the new tree vertex brings more it's neighbor vertices to process);
4. Repeat 2-3, untill all nodes are visited/included;

__A vertex cost is the cost between two neighbor vertices.__
