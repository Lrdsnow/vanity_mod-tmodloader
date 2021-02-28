using Terraria.ID;
using Terraria.ModLoader;

namespace vanity.Items
{
	public class Meowmere : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Meowmere"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Vanity Meowmere Looking Sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 0;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}