using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyITems.buffs
{
	public class Shine : ModBuff
	{
		public override void SetDefaults() 
        {
			DisplayName.SetDefault("The Arrow");
			Description.SetDefault("The full potential of the arrow lays in your grasp!");
            Main.debuff[Type] = false;
			Main.buffNoTimeDisplay[Type] = true;
		}
       public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[BuffID.Shine] = true;
			Lighting.AddLight(player.Center, 1.1f, 1.15f, 1.2f);
        }
    }
}