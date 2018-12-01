using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class ham : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ham");
			Tooltip.SetDefault("taste kinda funny...");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.melee = true;
			item.width = 35;
			item.height = 35;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Fish, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
