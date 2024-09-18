
namespace RomaniaRoadmapPathfinder
{
    enum Algorithms
    {
        BFS,
        DFS
    }

    class Program
    {
        /* PATTERNS: STRATEGY, DECORATOR, SINGLETON */

        /* TODO: Implement the A* search algorithm if I can make it work with the visitor pattern */
        /* TODO: Implement the observer pattern to notify other Pathfinders if path is found, so they stop. Work with threads. Each thread requires a different PathFinder object */

        static void Main(string[] args)
        {
            // Graph romaniaMap = Graph.GetInstance();
            Pathfinder pathFinder = new Pathfinder();
            string startCity = "Arad";
            //string startCity = "Fagaras";
            string targetCity = "Bucharest";

            /* Loop through all the algorithms */
            foreach (int algorithm in Enum.GetValues(typeof(Algorithms)))
            {
                ISearchStrategy strategy;
                /* Set the strategy based on the algorithm */
                switch (algorithm)
                {
                    case 0:
                        strategy = new CBreadthFirstSearchStrategy();
                        //pathFinder.SetStrategy(new CBreadthFirstSearchStrategy());
                        break;
                    case 1:
                        strategy = new CDepthFirstSearchStrategy();
                        //pathFinder.SetStrategy(new CDepthFirstSearchStrategy());
                        break;
                    default:
                        throw new Exception("Invalid algorithm");
                }

                /* Decorate the strategy with logging and metrics decorators */
                strategy = new LoggingDecorator(new MetricsDecorator(strategy));

                /* Set the strategy in the pathfinder */
                pathFinder.SetStrategy(strategy);

                /* Execute the pathfinding algorithm */
                List<string> path = pathFinder.Search(startCity, targetCity);
                Console.Write('\n');
            }
        }
    }
}