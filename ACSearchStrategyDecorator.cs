

namespace RomaniaRoadmapPathfinder
{
    public abstract class SearchStrategyDecorator : ISearchStrategy
    {
        /* The SearchStrategyDecorator class is the base decorator class that implements the ISearchStrategy interface. */
        protected ISearchStrategy _wrappedStrategy;
        public string Name => _wrappedStrategy.Name;
        public SearchStrategyDecorator(ISearchStrategy strategy)
        {
            _wrappedStrategy = strategy;
        }


        /* The SearchStrategyDecorator class delegates the pathfinding algorithm to the wrapped strategy object. */
        public virtual List<string> FindPath(string startCity, string targetCity)
        {
            return _wrappedStrategy.FindPath(startCity, targetCity);
        }
    }
}
