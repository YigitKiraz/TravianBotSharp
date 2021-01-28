﻿using System.Collections.Generic;
using TbsCore.Models.MapModels;
using TbsCore.Models.TroopsModels;

namespace TbsCore.Models.FarmingNonGoldModels
{
    public class FarmList
    {
        public FarmList()
        {
            Targets = new List<Farm>();
        }

        public string Name { get; set; }
        public List<Farm> Targets { get; set; }
    }

    public class Farm
    {
        public Coordinates coord { get; set; }
        public int Troop { get; set; }
        public int Amount { get; set; }
    }
}