using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasyITems
{
	public class EasyITems : Mod
	{
		public override void AddRecipeGroups()
 		{ 
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Lunar event Wings", new int[] 
           {
                ItemID.WingsStardust,
				ItemID.WingsSolar,
				ItemID.WingsNebula,
				ItemID.WingsVortex 
            });
            RecipeGroup.RegisterGroup("Lunar event wings", group);

			
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);    //this is an example of how to add an alternative recipe with RecipeGroup for nightsedge
            recipe.AddIngredient(null, "CBMage2");  //Adds an ingredient to this recipe with the given item name from the given mod, and with the given stack  
            recipe.AddIngredient(ItemID.IceSkates);   
            recipe.SetResult(ItemID.FrostsparkBoots);// Sets the result of this recipe with the given vanilla item name and stack size.
			recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.AddRecipe();

			recipe = new ModRecipe(this);    //this is an example of how to add an alternative recipe with RecipeGroup for nightsedge
            recipe.AddIngredient(null, "CBMelee2");  //Adds an ingredient to this recipe with the given item name from the given mod, and with the given stack  
            recipe.AddIngredient(ItemID.IceSkates);   
            recipe.SetResult(ItemID.FrostsparkBoots);// Sets the result of this recipe with the given vanilla item name and stack size.
			recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.AddRecipe();

			recipe = new ModRecipe(this);    //this is an example of how to add an alternative recipe with RecipeGroup for nightsedge
            recipe.AddIngredient(null, "CBRanged2");  //Adds an ingredient to this recipe with the given item name from the given mod, and with the given stack  
            recipe.AddIngredient(ItemID.IceSkates);   
            recipe.SetResult(ItemID.FrostsparkBoots);// Sets the result of this recipe with the given vanilla item name and stack size.
			recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.AddRecipe();
		}
		public EasyITems()
		{
		}
     }
}