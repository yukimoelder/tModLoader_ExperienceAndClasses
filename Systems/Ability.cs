﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace ExperienceAndClasses.Systems {
    public class Ability {
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Constants (and readonly) ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        public enum IDs : ushort {


            NUMBER_OF_IDs, //leave this second to last
            NONE, //leave this last
        }

        public const byte NUMBER_ABILITY_SLOTS_PER_CLASS = 4;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Instance Fields ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        private readonly string Internal_Name;

        public readonly IDs ID;
        public readonly ushort ID_num;

        public readonly PlayerClass.IDs Required_Class;
        public readonly byte Required_Class_num;
        public readonly byte Required_Level;
        public readonly Color Colour;

        public Texture2D Texture { get; protected set; }

        public string Name { get { return Language.GetTextValue("Mods.ExperienceAndClasses.Common.Ability_" + Internal_Name + "_Name"); } }
        public string Description { get { return Language.GetTextValue("Mods.ExperienceAndClasses.Common.Ability_" + Internal_Name + "_Description"); } }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Instance Variables ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        public bool Unlocked { get; private set; } = false;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Constructor ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        public Ability(IDs id, PlayerClass.IDs class_id, byte level) {
            ID = id;
            ID_num = (ushort)id;
            Internal_Name = Enum.GetName(typeof(IDs), ID_num);
            Required_Class = class_id;
            Required_Class_num = (byte)class_id;
            Required_Level = level;
            Colour = PlayerClass.LOOKUP[Required_Class_num].Colour;
        }

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Public Instance Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        /// <summary>
        /// Run once during init
        /// </summary>
        public void LoadTexture() {
            //TODO
        }

        public float CooldownPercent() {
            //TODO
            return 1f;
        }

    }
}
