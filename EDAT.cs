using EDAT.Items;
using EDAT.Tiles;
using GoodProLib.Bindings;
using GoodProLib.GData;
using GoodProLib.GUtils;
using Microsoft.Xna.Framework.Graphics;
using System.ComponentModel;
using System.Linq;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace EDAT
{
	public class EDAT : Mod
	{
		private Texture2D musicBoxes;

		public static bool unloadCalled = false;

		public override void Load()
		{
			unloadCalled = false;

			musicBoxes = Main.tileTexture[TileID.MusicBoxes];

			if(!Main.dedServ)
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"), ModContent.ItemType<KingSlime>(), ModContent.TileType<KingSlimeTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu"), ModContent.ItemType<EyeOfCthulhu>(), ModContent.TileType<EyeOfCthulhuTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EaterOfWorlds"), ModContent.ItemType<EaterOfWorlds>(), ModContent.TileType<EaterOfWorldsTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BrainOfCthulhu"), ModContent.ItemType<BrainOfCthulhu>(), ModContent.TileType<BrainOfCthulhuTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Twins"), ModContent.ItemType<Twins>(), ModContent.TileType<TwinsTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SkeletronPrime"), ModContent.ItemType<SkeletronPrime>(), ModContent.TileType<SkeletronPrimeTile>());
				//Destroyer box??
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DukeFishron"), ModContent.ItemType<DukeFishron>(), ModContent.TileType<DukeFishronTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LunaticCultist"), ModContent.ItemType<LunaticCultist>(), ModContent.TileType<LunaticCultistTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeRain"), ModContent.ItemType<SlimeRain>(), ModContent.TileType<SlimeRainTile>());
				//Blood moon??
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Party"), ModContent.ItemType<Party>(), ModContent.TileType<PartyTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/FrostLegion"), ModContent.ItemType<FrostLegion>(), ModContent.TileType<FrostLegionTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle"), ModContent.ItemType<JungleOverworld>(), ModContent.TileType<JungleOverworldTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GlowingMushroom"), ModContent.ItemType<MushroomOverworld>(), ModContent.TileType<MushroomOverworldTile>()); 
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundDesert"), ModContent.ItemType<UndergroundDesert>(), ModContent.TileType<UndergroundDesertTile>());
				//AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Marble"), ModContent.ItemType<Marble>(), ModContent.TileType<MarbleTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Granite"), ModContent.ItemType<Granite>(), ModContent.TileType<GraniteTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SpiderCave"), ModContent.ItemType<SpiderNest>(), ModContent.TileType<SpiderNestTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Village"), ModContent.ItemType<Town>(), ModContent.TileType<TownTile>());
			}
		}

		public override void Unload()
		{
			unloadCalled = true;

			if (!Main.dedServ)
				Main.tileTexture[TileID.MusicBoxes] = musicBoxes;
		}

		public override void PostSetupContent()
		{
			if (!Main.gameMenu)
			{
				if (!Main.dedServ)
				{
					musicBoxes = Main.tileTexture[TileID.MusicBoxes];
					ReplaceItemTexture(ItemID.MusicBoxCorruption, "Items/Replacments/Corruption", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxCrimson, "Items/Replacments/Crimson", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxDesert, "Items/Replacments/Desert", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxBoss3, "Items/Replacments/Destroyer", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxFrostMoon, "Items/Replacments/FrostMoon", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxBoss4, "Items/Replacments/Golem", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxTheHallow, "Items/Replacments/Hallow", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxHell, "Items/Replacments/Hell", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxIce, "Items/Replacments/Ice", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxMartians, "Items/Replacments/Martian", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxEerie, "Items/Replacments/Meteor", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxLunarBoss, "Items/Replacments/MoonLord", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxDD2, "Items/Replacments/OOA", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxTowers, "Items/Replacments/Pillar", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxBoss5, "Items/Replacments/QueenBee", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxRain, "Items/Replacments/Rain", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxSnow, "Items/Replacments/Snow", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxEclipse, "Items/Replacments/SolarEclipse", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxSpace, "Items/Replacments/Space", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxTitle, "Items/Replacments/Title", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxUndergroundCrimson, "Items/Replacments/UndergroundCrimson", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxUndergroundCorruption, "Items/Replacments/UndergroundCorruption", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxUndergroundHallow, "Items/Replacments/UndergroundHallow", unloadCalled);
					ReplaceItemTexture(ItemID.MusicBoxBoss2, "Items/Replacments/WallOfFlesh", unloadCalled);
				}
			}
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.musicVolume != 0)
			{
				if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
				{
					//Bosses as first priority for replacing themes
					if (Main.npc.Any(n => n.active && n.boss))
					{
						if (NPC.AnyNPCs(NPCID.KingSlime))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.EyeofCthulhu))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.EaterofWorldsHead))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/EaterOfWorlds");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.BrainofCthulhu))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/BrainOfCthulhu");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Twins");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.SkeletronPrime))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SkeletronPrime");
							priority = MusicPriority.BossHigh;
						}
						if (ModContent.GetInstance<Config>().DestroyerTheme && NPC.AnyNPCs(NPCID.TheDestroyer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/TheDestroyer");
							priority = MusicPriority.BossHigh;

						}
						if (NPC.AnyNPCs(NPCID.DukeFishron))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/DukeFishron");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.CultistBoss))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/LunaticCultist");
							priority = MusicPriority.BossHigh;
						}
					}
					//Invasions as second priority
					else if (Main.invasionX == Main.spawnTileX)
					{
						if (Main.slimeRain)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeRain");
							priority = MusicPriority.Event;
						}
						if (Main.bloodMoon)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/BloodMoon");
							priority = MusicPriority.Event;
						}
						if (BirthdayParty.PartyIsUp && BiomeData.ZoneTown)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Party");
							priority = MusicPriority.Event;
						}
						if (NPC.AnyNPCs(NPCID.MisterStabby) || NPC.AnyNPCs(NPCID.SnowmanGangsta) || NPC.AnyNPCs(NPCID.SnowBalla))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/FrostLegion");
							priority = MusicPriority.Event;
						}
					}
					//Biomes as third and last priority
					else
					{
						if (Main.LocalPlayer.ZoneJungle && !Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneGlowshroom && Main.LocalPlayer.ZoneOverworldHeight)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/GlowingMushroom");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneCorrupt && Main.LocalPlayer.ZoneRockLayerHeight && ModContent.GetInstance<Config>().UndergroundCorruptionTheme)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCorruption");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneCrimson && Main.LocalPlayer.ZoneRockLayerHeight && ModContent.GetInstance<Config>().UndergroundCrimsonTheme)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCrimson");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneUndergroundDesert && (Main.LocalPlayer.ZoneRockLayerHeight || Main.LocalPlayer.ZoneDirtLayerHeight))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundDesert");
							priority = MusicPriority.BiomeMedium;
						}
						if (BiomeData.ZoneMarble)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Marble");
							priority = MusicPriority.BiomeMedium;
						}
						if (BiomeData.ZoneGranite)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Granite");
							priority = MusicPriority.BiomeMedium;
						}
						if (BiomeData.ZoneSpiderCave)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SpiderCave");
							priority = MusicPriority.BiomeMedium;
						}
						if (BiomeData.ZoneTown)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Village");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneSnow && !Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = MusicID.Ice;
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneSnow && Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = MusicID.Snow;
							priority = MusicPriority.BiomeMedium;
						}
					}
				}
			}
		}

		public static void ReplaceItemTexture(int item, string newItemPath, bool unloadCalled)
		{
			Texture2D itemBackup = Main.itemTexture[item];

			if (unloadCalled)
				Main.itemTexture[item] = itemBackup;
			else
				Main.itemTexture[item] = ModContent.GetTexture(newItemPath);
		}

		public static void ReplaceItemTextures(int[] oldItems, string[] newItemPaths, bool unloadCalled)
		{
			foreach (string itemPath in newItemPaths)
			{
				foreach (int item in oldItems)
				{
					Texture2D itemBackup = Main.itemTexture[item];

					if (unloadCalled)
						Main.itemTexture[item] = itemBackup;
					else
						Main.itemTexture[item] = ModContent.GetTexture(itemPath);
				}
			}
		}
	}

	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Label("Destroyer's Theme Change")]
		[Tooltip("True to change Destoryer's theme. This is a config option because it's the last boss that uses Boss 3. True will have NO bosses play Boss 3, false will have the Destroyer play Boss 3.")]
		[DefaultValue(true)]
		public bool DestroyerTheme;

		[Label("Underground Corruption's Theme Change")]
		[Tooltip("True to change Underground Corruption's theme. This is a config option because it's the only biome that uses the vanilla underground corruption theme. True will have NO biomes play underground corruption, false will have the underground corruption play vanilla underground corruption")]
		[DefaultValue(true)]
		public bool UndergroundCorruptionTheme;

		[Label("Underground Crimson's Theme Change")]
		[Tooltip("True to change Underground Crimson's theme. This is a config option because it's the only biome that uses the vanilla underground crimson theme. True will have NO biomes play underground crimson, false will have the underground crimson play vanilla underground crimson")]
		[DefaultValue(true)]
		public bool UndergroundCrimsonTheme;
	}

	public class EDATPlayer : ModPlayer
	{
		public override void OnEnterWorld(Player player)
		{
			if (!Main.dedServ)
				switch (TileUtils.GetDungeonColor())
				{
					case DungeonColor.Pink:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_PinkDungeon");
						EDAT.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/PinkDungeon", EDAT.unloadCalled);
						break;
					case DungeonColor.Green:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_GreenDungeon");
						EDAT.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/GreenDungeon", EDAT.unloadCalled);
						break;
					case DungeonColor.Blue:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_BlueDungeon");
						EDAT.ReplaceItemTexture(ItemID.MusicBoxDungeon, "EDAT/Items/Replacments/BlueDungeon", EDAT.unloadCalled);
						break;
					case DungeonColor.None:
						Main.tileTexture[TileID.MusicBoxes] = ModContent.GetTexture("EDAT/MusicBoxes_BlueDungeon");
						break;
				}

		}
	}
}