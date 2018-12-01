using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class oceanblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("oceanblade");
			Tooltip.SetDefault("from the deepest depths.");
		}
		public override void SetDefaults()
		{
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Seashell, 3);
			recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddIngredient(ItemID.SandBlock, 25);
			recipe.AddIngredient(ItemID.Starfish, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
