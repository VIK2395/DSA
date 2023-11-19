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
1. Init costs store, select a random start vertex, set its cost 0, other vertices cost infinity;
2. Select current min cost vertex; mark as visited;
3. Calc and update costs of its (not visited) neighbors;
4. Repeat step 2-3 until all vertices are visited;

__A vertex cost is the cost of the path between the start vertex and the current vertex.__
