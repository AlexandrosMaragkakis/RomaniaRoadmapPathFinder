

namespace RomaniaRoadmapPathfinder
{
    public interface ISearchStrategy
    {
        /* The ISearchStrategy interface declares the operations that all concrete strategies must implement. */
        string Name { get; }

        /* Find the path from startCity to targetCity */
        List<string> FindPath(string startCity, string targetCity);
    }
}
