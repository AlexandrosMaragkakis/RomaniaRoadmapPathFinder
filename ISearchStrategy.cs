using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaniaRoadmapPathFinder
{
    public interface ISearchStrategy
    {
        List<string> FindPath(string startCity, string targetCity);

 
    }
}
