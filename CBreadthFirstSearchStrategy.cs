

namespace RomaniaRoadmapPathfinder
{
    public class CBreadthFirstSearchStrategy : ISearchStrategy
    {
        /* The CBreadthFirstSearchStrategy class is a concrete strategy that implements the BFS algorithm. */
        public string Name => "Breadth First Search";
        public Graph graph = Graph.GetInstance();
        public CBreadthFirstSearchStrategy() { }


        /* The FindPath method is the implementation of the BFS algorithm. */
        public List<string> FindPath(string startCity, string targetCity)
        {
            List<string> path = new List<string>();
            if (!graph.AdjacencyList.ContainsKey(startCity) || !graph.AdjacencyList.ContainsKey(targetCity))
            {
                Console.WriteLine("Start city or target city not found in the graph.");
                return path;
            }

            Queue<(string, List<string>)> queue = new Queue<(string, List<string>)>();
            HashSet<string> visited = new HashSet<string>();

            queue.Enqueue((startCity, new List<string> { startCity }));
            visited.Add(startCity);

            while (queue.Count > 0)
            {
                var (currentCity, currentPath) = queue.Dequeue();

                if (currentCity == targetCity)
                {
                    return currentPath;
                }

                foreach (var neighbor in graph.AdjacencyList[currentCity])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        var newPath = new List<string>(currentPath) { neighbor };
                        queue.Enqueue((neighbor, newPath));
                    }
                }
            }

            return path;
        }
    }
}

