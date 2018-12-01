using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class compressedhellstone : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("smaller without as much heat it allows for fine weapons!");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}