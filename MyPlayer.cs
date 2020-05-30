using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EDAT
{
	public class MyPlayer : ModPlayer
	{
		public int NPCsNearby;
		public bool ZoneBeeHive;
		public bool ZoneGranite;
		public bool ZoneMarble;

		public override void OnEnterWorld(Player player)
		{
			if (!Main.dedServ)
			{
				switch (Helper.GetDungeonColor())
				{
					case Helper.DungeonColor.Pink:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_PinkDungeon");
						Helper.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/PinkDungeon", ModContent.GetInstance<EDAT>().unloadCalled);
						break;
					case Helper.DungeonColor.Green:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_GreenDungeon");
						Helper.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/GreenDungeon", ModContent.GetInstance<EDAT>().unloadCalled);
						break;
					case Helper.DungeonColor.Blue:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_BlueDungeon");
						Helper.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/BlueDungeon", ModContent.GetInstance<EDAT>().unloadCalled);
						break;
					case Helper.DungeonColor.None:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_BlueDungeon");
						break;
				}
			}
		}

		public override void PreUpdate()
		{
			NPCsNearby = Main.npc.Count((NPC npc) => {
				return npc?.active == true && npc?.townNPC == true && Vector2.DistanceSquared(npc.position, player.Center) < 2250000;
			});
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			ZoneGranite = flags[0];
			ZoneMarble = flags[1];
			ZoneBeeHive = flags[2];
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = ZoneGranite;
			flags[1] = ZoneMarble;
			flags[2] = ZoneBeeHive;
			writer.Write(flags);
		}

		public override void UpdateBiomes()
		{
			ZoneGranite = MyWorld.ZoneGranite > 75;
			ZoneMarble = MyWorld.ZoneMarble > 75;
			ZoneBeeHive = MyWorld.ZoneBeehive > 75;
		}
	}
}