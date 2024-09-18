

namespace RomaniaRoadmapPathfinder
{
    public class MetricsDecorator : SearchStrategyDecorator
    {
        public MetricsDecorator(ISearchStrategy strategy) : base(strategy) { }

        /* The MetricsDecorator class overrides the FindPath method to measure the time it takes to find the path. */
        public override List<string> FindPath(string startCity, string targetCity)
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            var path = base.FindPath(startCity, targetCity);
            stopwatch.Stop();
            Console.WriteLine($"Pathfinding took {stopwatch.ElapsedMilliseconds} ms");
            return path;
        }
    }
}
