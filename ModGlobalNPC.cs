using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace yourmodnamehere.NPCs
{
    public class BunnySwordGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Bunny)
            {
                if (Main.rand.Next(75) == 0 && Main.hardMode)   //item rarity + drops only on hard mode
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BunnySword"));
                }
            }
        }
    }
}