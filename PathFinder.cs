

namespace RomaniaRoadmapPathfinder
{
    public class Pathfinder
    {
        /* The PathFinder class is the context class that uses the strategy. It has a reference to the ISearchStrategy interface. */
        public ISearchStrategy? _strategy;
        public Pathfinder() { }
        public void SetStrategy(ISearchStrategy strategy)
        {
            _strategy = strategy;
        }

        /* The PathFinder class delegates the pathfinding algorithm to the strategy object. */
        public List<string> Search(string startCity, string targetCity)
        {
            return _strategy.FindPath(startCity, targetCity);
        }

    }
}
