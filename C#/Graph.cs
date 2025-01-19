using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Graph
    {
        private readonly int vertices;

        // Contains the child nodes for each vertex of the graph 
        // assuming that the vertices are numbered 0 ... Size-1 
        private List<int>[] childNodes;

        /// <summary>Constructs an empty graph of given size</summary> 
        /// <param name="size">number of size</param> 
        public Graph(int size)
        {
            this.vertices = size;
            this.childNodes = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                // Assing an empty list of adjacents for each vertex 
                this.childNodes[i] = new List<int>();
            }
        }

        // Method to find all connected components
        public void FindConnectedComponents()
        {
            bool[] visited = new bool[vertices];
            List<List<int>> connectedComponents = new List<List<int>>();

            for (int i = 0; i < vertices; i++)
            {
                if (!visited[i])
                {
                    List<int> component = new List<int>();
                    ConnectedDFS(i, visited, component);
                    connectedComponents.Add(component);
                }
            }

            // Print all connected components
            Console.WriteLine("Connected Components:");
            foreach (var component in connectedComponents)
            {
                Console.WriteLine(string.Join(" ", component));
            }
        }

        // Helper method for Depth First Search (DFS)
        private void ConnectedDFS(int current, bool[] visited, List<int> component)
        {
            visited[current] = true;
            component.Add(current);

            foreach (int neighbor in childNodes[current])
            {
                if (!visited[neighbor])
                {
                    ConnectedDFS(neighbor, visited, component);
                }
            }
        }

        public void FindAllCycles()
        {
            bool[] visited = new bool[vertices];
            bool[] recursionStack = new bool[vertices];
            List<int> currentPath = new List<int>();

            for (int i = 0; i < vertices; i++)
            {
                if (!visited[i])
                {
                    FindCyclesDFS(i, visited, recursionStack, currentPath);
                }
            }
        }

        // Helper method to perform DFS and detect cycles
        private void FindCyclesDFS(int current, bool[] visited, bool[] recursionStack, List<int> currentPath)
        {
            visited[current] = true;
            recursionStack[current] = true;
            currentPath.Add(current);

            foreach (int neighbor in childNodes[current])
            {
                if (!visited[neighbor])
                {
                    FindCyclesDFS(neighbor, visited, recursionStack, currentPath);
                }
                else if (recursionStack[neighbor])
                {
                    // Cycle found, print it
                    int cycleStartIndex = currentPath.IndexOf(neighbor);
                    if (cycleStartIndex != -1)
                    {
                        Console.Write("Cycle: ");
                        for (int i = cycleStartIndex; i < currentPath.Count; i++)
                        {
                            Console.Write(currentPath[i] + " ");
                        }
                        Console.WriteLine(neighbor); // Complete the cycle
                    }
                }
            }
        }
        private void DFS(int vertex, bool[] visited)
        {
            // Mark the current vertex as visited
            visited[vertex] = true;

            // Process the vertex (e.g., print it)
            Console.WriteLine($"Visited vertex: {vertex}");

            // Recur for all adjacent vertices
            foreach (int neighbor in childNodes[vertex])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, visited);
                }
            }
        }

        // Utility function to perform DFS traversal for the entire graph
        public void PerformDFS()
        {
            bool[] visited = new bool[childNodes.Length];

            Console.WriteLine("Starting DFS traversal...");
            for (int i = 0; i < childNodes.Length; i++)
            {
                if (!visited[i])
                {
                    Console.WriteLine($"Starting new DFS from vertex {i}:");
                    DFS(i, visited);
                }
            }
        }

        // Utility function to perform BFS traversal for the entire graph
        public void BFS(int startVertex)
        {
            bool[] visited = new bool[childNodes.Length]; // Tracks visited vertices
            Queue<int> queue = new Queue<int>(); // Queue for BFS

            // Start BFS from the given vertex
            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            Console.WriteLine("BFS Traversal:");

            while (queue.Count > 0)
            {
                // Dequeue a vertex and process it
                int vertex = queue.Dequeue();
                Console.WriteLine($"Visited vertex: {vertex}");

                // Enqueue all unvisited neighbors
                foreach (int neighbor in childNodes[vertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        /// <summary>Constructs a graph by given list of 
        /// child nodes (successors) for each vertex</summary> 
        /// <param name="childNodes">children for each node</param> 
        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        /// <summary> 
        /// Returns the size of the graph (number of vertices) 
        /// </summary> 
        public int Size
        {
            get { return this.childNodes.Length; }
        }

        /// <summary>Adds new edge from u to v</summary>
        /// <param name="u">the starting vertex</param> 
        /// <param name="v">the ending vertex</param> 
        public void AddEdge(int u, int v)
        {
            childNodes[u].Add(v);
        }

        // Adds an undirected edge between vertices u and v
        public void AddUndriectedEdge(int u, int v)
        {
            childNodes[u].Add(v);
            childNodes[v].Add(u); // Since it's an undirected graph
        }

        /// <summary>Removes the edge from u to v if such exists 
        /// </summary> 
        /// <param name="u">the starting vertex</param> 
        /// <param name="v">the ending vertex</param> 
        public void RemoveEdge(int u, int v)
        {
            childNodes[u].Remove(v);
        }

        /// <summary> 
        /// Checks whether there is an edge between vertex u and v 
        /// </summary> 
        /// <param name="u">the starting vertex</param> 
        /// <param name="v">the ending vertex</param> 
        /// <returns>true if there is an edge between 
        /// vertex u and vertex v</returns> 
        public bool HasEdge(int u, int v)
        {
            bool hasEdge = childNodes[u].Contains(v);
            return hasEdge;
        }

        /// <summary>Returns the successors of a given vertex 
        /// </summary> 
        /// <param name="v">the vertex</param> 
        /// <returns>list of all successors of vertex v</returns> 
        public IList<int> GetSuccessors(int v)
        {
            return childNodes[v];
        }
    }
}
