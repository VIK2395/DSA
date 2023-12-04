Dijkstra's Shortest Path Algorithm:
- Works ONLY with connected graphs;
- Works ONLY with positive weights graphs;
- Works with positive CYCLICE graphs https://stackoverflow.com/questions/43394847/dijkstras-algorithm-and-cycles
  (It is incorrect explanation about "negative weight cycles", as it assumes visiting the same vertices more than once. The real reason why
  the algorithm works with cycles is that we keep track of the visited and never back to the same vertex, which prevents traversing the cycle)
- Works with BOTH directed and undirected graphs https://stackoverflow.com/questions/38190592/is-dijkstras-algorithm-for-directed-or-undirected-graphs
  
Bellman–Ford algorithm for graphs with negative weights.

https://www.youtube.com/watch?v=bZkzH5x0SKU \
![image](https://github.com/VIK2395/DSA/assets/50545334/a9691360-d51e-4f86-bff7-74875ad574e3)

Idea uder the hood:
1. Init costs store, set start vertex cost 0, other vertices cost infinity;
2. Select current min cost vertex; mark as visited;
3. Calc and update costs of its (not visited) neighbors;
4. Repeat step 2-3 until all vertices are visited;

__A vertex cost is the cost of the path between the start vertex and the current vertex.__

LeetCode:\
https://leetcode.com/problems/network-delay-time/?envType=list&envId=ob9rj7ig \
https://www.youtube.com/watch?v=EaphyqKU4PQ
