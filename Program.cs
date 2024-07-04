using System;
using System.Collections.Generic;
using System.Net;

namespace RomaniaRoadmapPathFinder
{
    enum Algorithms
    {
        BFS,
        DFS
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph romaniaMap = Graph.GetInstance();
            PathFinder pathFinder = new PathFinder();
            string startCity = "Arad";
            //string startCity = "Fagaras";
            string targetCity = "Bucharest";

            
            foreach (int algorithm in Enum.GetValues(typeof(Algorithms)))
            {
                switch (algorithm)
                {
                    case 0:
                        pathFinder.SetStrategy(new CBreadthFirstSearchStrategy());
                        break;
                    case 1:
                        pathFinder.SetStrategy(new CDepthFirstSearchStrategy());
                        break;
                }


                List<string> path = pathFinder.Search(startCity, targetCity);
                foreach (string city in path)
                {
                    Console.Write(city + " ");
                }
                Console.Write('\n');
            }
        }
    }
}