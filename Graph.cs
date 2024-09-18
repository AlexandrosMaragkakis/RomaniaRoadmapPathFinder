

namespace RomaniaRoadmapPathfinder
{
    public class Graph
    {
        /* The Graph class is the data structure that the strategies use to find the path. It is a singleton class that contains the adjacency list of the cities. */
        private static Graph _instance;
        public Dictionary<string, HashSet<string>> AdjacencyList { get; }

        // Singleton pattern
        public static Graph GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Graph();
            }
            return _instance;
        }

        private Graph()
        {
            AdjacencyList = new Dictionary<string, HashSet<string>>();

            // Adding edges between cities
            AddEdge("Arad", "Zerind");
            AddEdge("Arad", "Sibiu");
            AddEdge("Arad", "Timisoara");

            AddEdge("Zerind", "Arad");
            AddEdge("Zerind", "Oradea");

            AddEdge("Oradea", "Zerind");
            AddEdge("Oradea", "Sibiu");

            AddEdge("Sibiu", "Arad");
            AddEdge("Sibiu", "Oradea");
            AddEdge("Sibiu", "Fagaras");
            AddEdge("Sibiu", "Rimnicu Vilcea");

            AddEdge("Timisoara", "Arad");
            AddEdge("Timisoara", "Lugoj");

            AddEdge("Lugoj", "Timisoara");
            AddEdge("Lugoj", "Mehadia");

            AddEdge("Mehadia", "Lugoj");
            AddEdge("Mehadia", "Drobeta");

            AddEdge("Drobeta", "Mehadia");
            AddEdge("Drobeta", "Craiova");

            AddEdge("Craiova", "Drobeta");
            AddEdge("Craiova", "Rimnicu Vilcea");
            AddEdge("Craiova", "Pitesti");

            AddEdge("Rimnicu Vilcea", "Sibiu");
            AddEdge("Rimnicu Vilcea", "Craiova");
            AddEdge("Rimnicu Vilcea", "Pitesti");

            AddEdge("Fagaras", "Sibiu");
            AddEdge("Fagaras", "Bucharest");

            AddEdge("Pitesti", "Rimnicu Vilcea");
            AddEdge("Pitesti", "Craiova");
            AddEdge("Pitesti", "Bucharest");

            AddEdge("Bucharest", "Fagaras");
            AddEdge("Bucharest", "Pitesti");
            AddEdge("Bucharest", "Giurgiu");
            AddEdge("Bucharest", "Urziceni");

            AddEdge("Giurgiu", "Bucharest");

            AddEdge("Urziceni", "Bucharest");
            AddEdge("Urziceni", "Vaslui");
            AddEdge("Urziceni", "Hirsova");

            AddEdge("Vaslui", "Urziceni");
            AddEdge("Vaslui", "Iasi");

            AddEdge("Iasi", "Vaslui");
            AddEdge("Iasi", "Neamt");

            AddEdge("Neamt", "Iasi");

            AddEdge("Hirsova", "Urziceni");
            AddEdge("Hirsova", "Eforie");

            AddEdge("Eforie", "Hirsova");
        }

        /* Add an edge between two cities */
        private void AddEdge(string source, string destination)
        {
            if (!AdjacencyList.ContainsKey(source))
            {
                AdjacencyList[source] = new HashSet<string>();
            }
            AdjacencyList[source].Add(destination);
        }
    }
}
