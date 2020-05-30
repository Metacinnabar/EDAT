using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EDAT
{
	public static class Helper
	{
		public static void ReplaceItemTexture(int item, string newItemPath, bool unloadCalled)
		{
			Texture2D itemBackup = Main.itemTexture[item];

			if (unloadCalled)
				Main.itemTexture[item] = itemBackup;
			else
				Main.itemTexture[item] = ModContent.GetTexture(newItemPath);
		}

		public static int TileAmountInWorld(int[] tileId)
		{
			int count = 0;

			for (int x = 0; x < Main.maxTilesX; x++)
			{
				for (int y = 0; y < Main.maxTilesY; y++)
				{
					for (int tile = 0; tile < tileId.Length; tile++)
					{
						if (WorldGen.InWorld(x, y) && Main.tile[x, y]?.type == tileId[tile])
							count++;
					}
				}
			}

			return count;
		}

		public static int WallAmountInWorld(int[] wallId)
		{
			int count = 0;

			for (int x = 0; x < Main.maxTilesX; x++)
			{
				for (int y = 0; y < Main.maxTilesY; y++)
				{
					for (int wall = 0; wall < wallId.Length; wall++)
					{
						if (WorldGen.InWorld(x, y) && Main.tile[x, y]?.wall == wallId[wall])
							count++;
					}
				}
			}

			return count;
		}

		public static DungeonColor GetDungeonColor()
		{
			int blueTiles = BlueDungeonTiles();
			int greenTiles = GreenDungeonTiles();
			int pinkTiles = PinkDungeonTiles();

			return blueTiles > greenTiles && blueTiles > pinkTiles
				? DungeonColor.Blue
				: greenTiles > blueTiles && greenTiles > pinkTiles
				? DungeonColor.Green
				: pinkTiles > greenTiles && pinkTiles > blueTiles ? DungeonColor.Pink : DungeonColor.None;
		}

		public static int BlueDungeonTiles()
		{
			int amount = TileAmountInWorld(new int[] { TileID.BlueDungeonBrick });
			amount += WallAmountInWorld(new int[] { WallID.BlueDungeonSlabUnsafe, WallID.BlueDungeonTileUnsafe, WallID.BlueDungeonUnsafe });
			return amount;
		}

		public static int GreenDungeonTiles()
		{
			int amount = TileAmountInWorld(new int[] { TileID.GreenDungeonBrick });
			amount += WallAmountInWorld(new int[] { WallID.GreenDungeonSlabUnsafe, WallID.GreenDungeonTileUnsafe, WallID.GreenDungeonUnsafe });
			return amount;
		}

		public static int PinkDungeonTiles()
		{
			int amount = TileAmountInWorld(new int[] { TileID.PinkDungeonBrick });
			amount += WallAmountInWorld(new int[] { WallID.PinkDungeonSlabUnsafe, WallID.PinkDungeonTileUnsafe, WallID.PinkDungeonUnsafe });
			return amount;
		}

		public enum DungeonColor : byte
		{
			None,
			Pink,
			Green,
			Blue
		}
	}
}