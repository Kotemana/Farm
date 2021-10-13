using System.Collections.Generic;

namespace Farm
{
    public class Building
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int AnimalsCapacity { get; set; }
        public List<Animal> Animals { get; set; }
    }
}