﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ExperienceAndClasses.Items {
    public abstract class MItem : ModItem {
        private const int STACK_SIZE = 99999;

        private readonly string NAME, TOOLTIP, TEXTURE;
        private readonly bool CONSUMABLE;
        private readonly int WIDTH, HEIGHT, RARITY;

        protected MItem(string name, string tooltip, string texture, bool consumable, int width, int height, int rarity) {
            NAME = name;
            TOOLTIP = tooltip;
            TEXTURE = texture;
            CONSUMABLE = consumable;
            WIDTH = width;
            HEIGHT = height;
            RARITY = rarity;
        }

        public override void SetStaticDefaults() {
            DisplayName.SetDefault(NAME);
            base.Tooltip.SetDefault(TOOLTIP);
        }
        public override void SetDefaults() {
            item.maxStack = STACK_SIZE;

            item.width = WIDTH;
            item.height = HEIGHT;

            item.rare = RARITY;

            if (CONSUMABLE) {
                item.consumable = true;
                item.useAnimation = 10;
                item.useTime = 10;
                item.useStyle = 4;
            }
        }
        public override void OnCraft(Recipe recipe) {
            item.maxStack = STACK_SIZE;
            base.OnCraft(recipe);
        }
        public override void UpdateInventory(Player player) {
            item.maxStack = STACK_SIZE;
            base.UpdateInventory(player);
        }
        public override string Texture {
            get {
                return TEXTURE;
            }
        }

        public string GetLocalizedName() {
            return Commons.GetItemLocalizedName(this);
        }
    }
}
