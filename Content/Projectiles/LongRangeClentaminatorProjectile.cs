using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

public class LongRangeClentaminatorProjectile : GlobalProjectile
{
    public override void SetDefaults(Projectile projectile)
    {
        if (projectile.type == ProjectileID.PureSpray
            || projectile.type == ProjectileID.CorruptSpray
            || projectile.type == ProjectileID.HallowSpray
            || projectile.type == ProjectileID.CrimsonSpray
            || projectile.type == ProjectileID.MushroomSpray
            || projectile.type == ProjectileID.SandSpray
            || projectile.type == ProjectileID.SnowSpray
            || projectile.type == ProjectileID.DirtSpray)
        {

            projectile.timeLeft *= 2;
            projectile.scale = 5f;
        }
    }
    public override void AI(Projectile projectile)
    {
        if (projectile.timeLeft == 120) // Ensures it only plays once per shot
        {
            SoundEngine.PlaySound(SoundID.Item13, projectile.position);
        }
        for (int i = 0; i < 3; i++) // Spawn 3 times more dust
        {
            if (projectile.type == ProjectileID.PureSpray)
            {
                Lighting.AddLight(projectile.Center, 0.519f, 2.13f, 0.54f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.PureSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f); // Increase scale to 1.5
            }
            else if (projectile.type == ProjectileID.CorruptSpray)
            {
                Lighting.AddLight(projectile.Center, 1.8f, 0.3f, 2.4f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.CorruptSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.CrimsonSpray)
            {
                Lighting.AddLight(projectile.Center, 2.7f, 0.3f, 0.9f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.CrimsonSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.HallowSpray)
            {
                Lighting.AddLight(projectile.Center, 0.9f, 2.1f, 3.0f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.HallowSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.MushroomSpray)
            {
                Lighting.AddLight(projectile.Center, 0.39f, 0.39f, 2.883f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.MushroomSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.SandSpray)
            {
                Lighting.AddLight(projectile.Center, 3f, 2.8f, 0f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.SandSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.SnowSpray)
            {
                Lighting.AddLight(projectile.Center, 3f, 3f, 3f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.SnowSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }
            else if (projectile.type == ProjectileID.DirtSpray)
            {
                Lighting.AddLight(projectile.Center, 1.5f, 0.89f, 3f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.DirtSpray,
                             projectile.velocity.X * Main.rand.NextFloat(0.5f, 1.5f),
                             projectile.velocity.Y * Main.rand.NextFloat(0.5f, 1.5f),
                             0, default(Color), 1.5f);
            }

        }
    }
}