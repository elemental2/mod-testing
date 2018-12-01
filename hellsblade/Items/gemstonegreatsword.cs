using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class gemstonegreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gemstone Greatsword");
			Tooltip.SetDefault("made with elements of hell.");
		}
		public override void SetDefaults()
		{
			item.damage = 76;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 20;
			item.useAnimation = 20;
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
			recipe.AddIngredient(ItemID.Ruby, 8);
			recipe.AddIngredient(ItemID.Emerald, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
