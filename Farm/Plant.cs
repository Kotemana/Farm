namespace Farm
{
    public class Plant
    {
        public string Name { get; set; }
        public int AreaConsumed { get; set; }
        public Season PlantSeason { get; set; }
        public Season HarvestSeason { get; set; }
    }
}