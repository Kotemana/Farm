using System;
using System.Collections.Generic;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var farm = FarmHelper.CreateBaseFarm();
            FarmHelper.PlayWithFarm(farm);
        }
    }
}
