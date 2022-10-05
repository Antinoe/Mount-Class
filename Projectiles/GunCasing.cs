using System;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.GameContent.Events;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MountClass.Projectiles
{
    public class GunCasing : ModProjectile
    {
		protected int collide = 4;
		
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gun Casing");
        }

        public override void SetDefaults()
        {
            Projectile.width = 5;
            Projectile.height = 7;
            Projectile.aiStyle = 14;
            Projectile.timeLeft = 600;
            Projectile.light = 0f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
        }
		
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (collide > 0)
			{
				collide--;
				Projectile.velocity.X -= 0.01f;
				Projectile.velocity.Y -= 0.01f;
				SoundEngine.PlaySound(Sounds.Mech.CasingMachineGun, Projectile.position);
				return true;
			}
			return true;
		}
    }
}