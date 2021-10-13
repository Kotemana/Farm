using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Farm
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Gardenbed> Gardenbeds { get; set; } = new List<Gardenbed>();
        public List<Building> Buildings { get; set; } = new List<Building>();

        public void Report()
        {
            Console.WriteLine($"This is {Name} farm, it has area of {Area}, with {Gardenbeds.Count} gardenbeds and {Buildings.Count} buildings");
        }

        public void GardenbedReport()
        {
            Console.WriteLine($"{Name} Farm has {Gardenbeds.Count} gardenbeds:");
            foreach (var gardenbed in Gardenbeds)
            {
                Console.WriteLine($"- Gardenbed area is {gardenbed.Area}, plants are:");
                var consumedArea = 0;
                foreach (var plant in gardenbed.Plants)
                {
                    Console.WriteLine($"\t - {plant.Name}, area consumed {plant.AreaConsumed}");
                    consumedArea += plant.AreaConsumed;
                }
                Console.WriteLine($"Gardenbed usage: {(consumedArea / (double) gardenbed.Area) * 100}%");
            }
        }

        /// <summary>
        /// Adds gardenbed if farm has enough area
        /// </summary>
        /// <param name="gardenbed">Gardenbed to add</param>
        public void AddGardenbed(Gardenbed gardenbed)
        {
            if (Area - AreaConsumed() < gardenbed.Area)
            {
                Console.WriteLine("Not Enough Area, Idi naher");
                return;
            }
            Console.WriteLine("Enough Area, Adding Gardenbed");
            Gardenbeds.Add(gardenbed);
        }

        private int AreaConsumed()
        {
            var areaConsumed = 0;
            foreach (var gardenbed in Gardenbeds)
            {
                areaConsumed += gardenbed.Area;
            }
            foreach (var building in Buildings)
            {
                areaConsumed += building.Area;
            }
            return areaConsumed;
        }
    }
}
