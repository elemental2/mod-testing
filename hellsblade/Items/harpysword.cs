using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class harpysword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("harpysword");
			Tooltip.SetDefault("light as a feather.");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
