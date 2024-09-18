

namespace RomaniaRoadmapPathfinder
{
    public class LoggingDecorator : SearchStrategyDecorator
    {
        public LoggingDecorator(ISearchStrategy strategy) : base(strategy) { }

        /* The LoggingDecorator class overrides the FindPath method to log the pathfinding process. */
        public override List<string> FindPath(string startCity, string targetCity)
        {
            Console.WriteLine($"Using algorithm: {base.Name}");
            Console.WriteLine($"Starting pathfinding from {startCity} to {targetCity}");
            var path = base.FindPath(startCity, targetCity);
            Console.WriteLine($"Finished pathfinding with path: {string.Join(" -> ", path)}");
            return path;
        }
    }

}
