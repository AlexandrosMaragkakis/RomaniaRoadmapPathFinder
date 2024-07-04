using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RomaniaRoadmapPathFinder
{
    public class PathFinder
    {
        public ISearchStrategy? _strategy;
        public PathFinder() { }
        

        public void SetStrategy(ISearchStrategy strategy)
        {
            _strategy = strategy;
        }

        
        public List<string> Search(string startCity, string targetCity)
        {
            return _strategy.FindPath(startCity, targetCity);
        }

    }
}
