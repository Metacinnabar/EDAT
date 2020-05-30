using Terraria;
using Terraria.ID;

namespace EDAT
{
	public static class ExtraBiomes
	{
		public static bool ZoneBeeHive(Player player) => player.GetModPlayer<MyPlayer>().ZoneBeeHive;

		public static bool ZoneGranite(Player player) => player.GetModPlayer<MyPlayer>().ZoneGranite;

		public static bool ZoneMarble(Player player) => player.GetModPlayer<MyPlayer>().ZoneMarble;

		public static bool ZoneSpiderCave(Player player) => Main.tile[(int)player.position.X / 16, (int)player.position.Y / 16].wall == WallID.SpiderUnsafe;

		public static bool ZoneTown(Player player) => player.GetModPlayer<MyPlayer>().NPCsNearby > 2 && Main.dayTime;
	}
}