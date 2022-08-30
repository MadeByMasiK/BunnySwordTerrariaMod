using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace BunnySwordTerrariaMod.NPCs
{
    [AutoloadHead]
    public class BunnyNPC : ModNPC
    {
        public override string Texture
        {
            get {return "BunnySwordTerrariaMod/NPCs/Bunny";} //insert file path here
        }
    
        public override string[] AltTextures
        {
            get {return new[] {"BunnySwordTerrariaMod/NPCs/Amber_Bunny"};} //insert file path here
        }

        public override bool Autoload(ref string name)
        {
            name = "Bunny";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 27;
            NPCID.Sets.ExtraFramesCount[npc.type] = 10;
            NPCID.Sets.AttackFrameCount[npc.type] = 0;
            NPCID.Sets.DangerDetectRange[npc.type] = 1000;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 28;
            npc.height = 26;
            npc.aiStyle = 7;
            npc.damage = 25;
            npc.defense = 10;
            npc.lifeMax = 1234;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Bunny;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for(int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if(!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if(item.type == mod.ItemType("BunnySword"))
                    {
                        return true;
                    }
                    if(item.type == mod.ItemType("MasterBunnySword"))
                    {
                        return true;
                    }
                }
            }
            return false; 
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(5))
            {
                case 0:
                    return "Carrot";
                case 1:
                    return "Wanda";
                case 2:
                    return "Bepo";
                default:
                    return "Tristan";
            }
        }

        public override string GetChat()
        {
            switch(Main.rand.Next(4))
            {
                case 0:
                    return "Carrots are great food";
                case 1:
                    return "Mushrooms make me feel sick";
                case 2:
                    return "I am stronger during full moon! (Actually it isn't true but it sounds cool!)";
                default:
                    return "I don't feel like talking";
            }
        }

            // Tutorial, how to add shop, etc. https://www.youtube.com/watch?v=olNE185kLkM&list=PLYaXRYIpx67FZgU3fXKbsJ8DsEIwkgb8m&index=12

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("MasterBunnySword"));
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 25;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 20;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = mod.ProjectileType("BunnyProjectile");
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 5f;
            randomOffset = 2f;
        }
    }
}