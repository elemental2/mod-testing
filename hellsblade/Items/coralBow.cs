using Terraria.ID;
using Terraria.ModLoader;

namespace hellsblade.Items
{
	public class coralBow : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 19;
			item.width = 18;
			item.noMelee = true;
			item.height = 56;
			item.ranged = true;
			item.useTime = 30;
			item.shoot = 1;
			item.shootSpeed = 12f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 2500;
			item.useAmmo = AmmoID.Arrow;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coral Bow");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BorealWood, 30);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
