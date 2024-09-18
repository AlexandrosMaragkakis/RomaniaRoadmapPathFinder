

namespace RomaniaRoadmapPathfinder
{
    public class CDepthFirstSearchStrategy : ISearchStrategy // ai generated
    {
        /* The DepthFirstSearchStrategy class is a concrete strategy that implements the DFS algorithm. */
        public string Name => "Depth First Search";
        public Graph graph = Graph.GetInstance();

        private string? _targetCity;
        private HashSet<string> visited;

        public CDepthFirstSearchStrategy()
        {
            visited = new HashSet<string>();
        }


        /* The FindPath method is the implementation of the DFS algorithm. */
        public List<string> FindPath(string startCity, string targetCity)
        {

            _targetCity = targetCity;
            List<string> path = new List<string>();
            if (!graph.AdjacencyList.ContainsKey(startCity) || !graph.AdjacencyList.ContainsKey(targetCity))
            {
                Console.WriteLine("Start city or target city not found in the graph.");
                return path;
            }

            DFSUtil(startCity, path);
            return path;
        }

        /* The DFSUtil method is a recursive utility function that performs the DFS algorithm. */
        private bool DFSUtil(string city, List<string> path)
        {
            visited.Add(city);
            path.Add(city);

            if (city == _targetCity)
            {
                return true;
            }

            foreach (string neighbor in graph.AdjacencyList[city])
            {
                if (!visited.Contains(neighbor))
                {
                    if (DFSUtil(neighbor, path))
                    {
                        return true;
                    }
                }
            }

            path.RemoveAt(path.Count - 1);
            return false;
        }
    }
}

