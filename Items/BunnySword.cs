using Terraria.ID;
using Terraria.ModLoader;

namespace BunnySword.Items
{
	public class BunnySword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BunnySword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The best that a cute bunny can offer you");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = -12;
			// item.UseSound = SoundID.Item1;   THIS WAS ORIGINAL SWORD SOUND
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Bunny");
			item.autoReuse = true;
			item.scale = 2f;
		}

		/* public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		*/
	}
}