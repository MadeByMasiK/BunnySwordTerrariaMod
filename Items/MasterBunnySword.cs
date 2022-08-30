using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnySwordTerrariaMod.Items
{
	public class MasterBunnySword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Master Bunny Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Actually the best that a cute bunny can offer you");
		}

		public override void SetDefaults() 
		{
			item.damage = 400;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 10000;
			item.rare = -12;
			// item.UseSound = SoundID.Item1;   THIS WAS ORIGINAL SWORD SOUND
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Bunny");
			item.autoReuse = true;
			item.scale = 2.4f;
			item.shoot = mod.ProjectileType("BunnyProjectile");
            item.shootSpeed = 15f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10); // Luminite Bar
			recipe.AddIngredient(mod.ItemType("BunnySword"));
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}