using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class hellsblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("hell's blade");
			Tooltip.SetDefault("made with elements of hell.");
		}
		public override void SetDefaults()
		{
			item.damage = 56;
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
			recipe.AddIngredient(ItemID.FieryGreatsword, 2);
			recipe.AddIngredient(mod.ItemType("compressedhellstone"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
