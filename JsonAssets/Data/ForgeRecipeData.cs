﻿using Microsoft.Xna.Framework;
using StardewValley.GameData.Crafting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssets.Data
{
    public class ForgeRecipeData
    {
        public string EnableWithMod { get; set; }
        public string DisableWithMod { get; set; }

        public string BaseItemName { get; set; } // Checks by Item.Name, so supports anything
        public string IngredientContextTag { get; set; }
        public int CinderShardCost { get; set; }

        public string ResultItemName { get; set; } // Uses Utility.fuzzyItemSearch, so go nuts

        public string[] AbleToForgeConditions { get; set; }
    }
}
