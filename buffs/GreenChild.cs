using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyITems.buffs
{
	public class GreenChild : ModBuff
	{
		public override void SetDefaults() 
        {
			DisplayName.SetDefault("Green Child");
			Description.SetDefault("Press UP to reverse gravity");
            Main.debuff[Type] = false;
			Main.buffNoTimeDisplay[Type] = true;
		}
       public override void Update(Player player, ref int buffIndex)
		{
			player.gravControl = true;
        }
    }
}