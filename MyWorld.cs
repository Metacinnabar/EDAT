using Terraria.ID;
using Terraria.ModLoader;

namespace EDAT
{
	public class MyWorld : ModWorld
	{
		public static int ZoneBeehive;
		public static int ZoneGranite;
		public static int ZoneMarble;

		public override void TileCountsAvailable(int[] tileCounts)
		{
			ZoneGranite = tileCounts[TileID.Granite];
			ZoneMarble = tileCounts[TileID.Marble];
			ZoneBeehive = tileCounts[TileID.Hive];
		}
	}
}