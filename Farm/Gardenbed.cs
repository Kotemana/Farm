using System.Collections.Generic;

namespace Farm
{
    public class Gardenbed
    {
        public int Area { get; set; }
        public List<Plant> Plants { get; set; } = new List<Plant>();
    }
}