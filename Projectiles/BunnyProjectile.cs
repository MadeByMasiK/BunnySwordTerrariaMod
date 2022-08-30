using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BunnySwordTerrariaMod.Projectiles
{

    public class BunnyProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bunny Projectile");
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 28;
            projectile.height = 26;
            projectile.aiStyle = 0;
            projectile.damage = 150;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.penetrate = 30;
            projectile.timeLeft = 500;
            projectile.light = 0.75f;
            projectile.ignoreWater = true;
        }

/*        public override void AI()
        {
            int dust = Dust.NewDust(projectile.Center, 1, 1, 11, 0f, 0f, 0, default(Color). 1f);
            Main.Dust[dust].velocity *= 0.2f;
            Main.Dust[dust].scale = (float)Main.rand.Next(80,115) * 0.013f;
            Main.Dust[dust].noGravity = true;
        } */
    }
}