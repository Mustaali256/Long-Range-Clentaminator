using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace LongRangeClentaminator.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class LongRangeClentaminator : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.LongRangeClentaminator.hjson' file.
        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Clentaminator); // Copy properties from Clentaminator
            Item.value = Item.sellPrice(gold: 46, silver: 97);
            Item.shoot = ProjectileID.PureSpray; // Shoots solutions
            Item.shootSpeed = 75f;
            
        }
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            // Move the projectile spawn position closer to the player
            position -= velocity.SafeNormalize(Vector2.Zero) * 1f; // Reduce the offset (default is ~25f)
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Clentaminator) // Requires a normal Clentaminator
                .AddIngredient(ItemID.CopperBar, 5)
                .AddIngredient(ItemID.DemoniteBar, 5)
                .AddIngredient(ItemID.ChlorophyteBar, 5)
                .AddIngredient(ItemID.HallowedBar, 5)
                .AddTile(TileID.MythrilAnvil) // Requires a Mythril/Orichalcum Anvil
                .Register();
            CreateRecipe()
                .AddIngredient(ItemID.Clentaminator) // Requires a normal Clentaminator
                .AddIngredient(ItemID.CopperBar, 5)
                .AddIngredient(ItemID.CrimtaneBar, 5)
                .AddIngredient(ItemID.ChlorophyteBar, 5)
                .AddIngredient(ItemID.HallowedBar, 5)
                .AddTile(TileID.MythrilAnvil) // Requires a Mythril/Orichalcum Anvil
                .Register();
        }

    }
}
