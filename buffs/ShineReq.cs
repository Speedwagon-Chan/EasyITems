using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyITems.buffs
{
	public class ShineReq : ModBuff
	{
		public override void SetDefaults() 
        {
			DisplayName.SetDefault("Requiem");
			Description.SetDefault("Your progression feels complete! your body is surging with energy!");
            Main.debuff[Type] = false;
			Main.buffNoTimeDisplay[Type] = true;
		}
       public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[BuffID.Shine] = true;
			player.gills = true;
			Lighting.AddLight(player.Center, 1.1f, 1.15f, 1.2f);
        }
    }
}