namespace Farm
{
    public static class FarmHelper
    {
        public static Farm CreateBaseFarm()
        {
            var farm = new Farm() { Area = 100, Name = "Asino" };

            var gardenbedPidBurachki = new Gardenbed() { Area = 20 };
            var burachok = new Plant()
            {
                AreaConsumed = 10,
                Name = "Burachok",
                HarvestSeason = Season.Summer,
                PlantSeason = Season.Spring
            };
            var sweetBurachok = new Plant()
            {
                AreaConsumed = 5,
                Name = "Sweet Burachok",
                HarvestSeason = Season.Autumn,
                PlantSeason = Season.Spring
            };
            gardenbedPidBurachki.Plants.Add(burachok);
            gardenbedPidBurachki.Plants.Add(sweetBurachok);
            farm.Gardenbeds.Add(gardenbedPidBurachki);
            return farm;
        }

        public static void PlayWithFarm(Farm farm)
        {
            farm.Report();
            farm.GardenbedReport();
            var gardenBedStrawberries = new Gardenbed() { Area = 50 };
            var bigStrawberyBush = new Plant { Name = "Strawberry", AreaConsumed = 40 };
            gardenBedStrawberries.Plants.Add(bigStrawberyBush);

            farm.AddGardenbed(gardenBedStrawberries);

            farm.GardenbedReport();
            var gardenBedBluberries = new Gardenbed() { Area = 40 };
            var bigBluberryBush = new Plant { Name = "Blueberry", AreaConsumed = 30 };
            gardenBedBluberries.Plants.Add(bigBluberryBush);
            farm.AddGardenbed(gardenBedBluberries);
            farm.GardenbedReport();
        }
    }
}
