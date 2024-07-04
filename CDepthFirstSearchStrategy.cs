using RomaniaRoadmapPathFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaniaRoadmapPathFinder
{
    public class CDepthFirstSearchStrategy : ISearchStrategy
    {
        public Graph graph = Graph.GetInstance();
        
        private string? _targetCity;
        private HashSet<string> visited;

        public CDepthFirstSearchStrategy()
        {
            visited = new HashSet<string>();
        }

        

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

