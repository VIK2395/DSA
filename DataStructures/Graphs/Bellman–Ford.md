LeetCode:\
https://leetcode.com/problems/cheapest-flights-within-k-stops/

https://www.geeksforgeeks.org/bellman-ford-algorithm-dp-23

- originally for __directed__ graphs; can work only with __undirected positive__ graphs (fails for undirected graphs with negative edges as it counts as negative cycle):\
  https://stackoverflow.com/questions/14785413/can-we-apply-the-bellman-ford-algorithm-to-an-undirected-graph
  https://yuminlee2.medium.com/bellman-ford-algorithm-9f9f331b4291#b56c
- weighted and unweighted graphs;
- positive and negative edge weights;
- works with positive cycles for directed and undirected graphs;
- doesn't work with negative cycles;
- can detect negative cycles and determine where they occur;
