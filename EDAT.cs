using System;
using System.ComponentModel;
using System.Reflection;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace EDAT
{
	public class EDAT : Mod
	{
		public override void Load()
		{/*
			try
			{
				Type mod = typeof(ModLoader).Assembly?.GetType("Terraria.ModLoader.Mod");
				PropertyInfo displayName = mod?.GetProperty("DisplayName", BindingFlags.Public | BindingFlags.Instance);
				displayName?.SetValue(mod, $"[i/{ModContent.ItemType<Unbenannt>()}] [c/1cd85e:Everything Deserves a Theme]");
			}
			catch (Exception e)
			{
				Logger.Error("Reflection Error EDAT: " + e);
			}*/
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.musicVolume != 0)
			{
				if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
				{
					//Bosses
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
					//queen bee??
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
					if (ModContent.GetInstance<Config>().DestroyerTheme)
					{
						if (NPC.AnyNPCs(NPCID.TheDestroyer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/TheDestroyer");
							priority = MusicPriority.BossHigh;
						}
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
					//Biomes
					if (Main.LocalPlayer.ZoneUndergroundDesert)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundDesert");
						priority = MusicPriority.BiomeMedium;
					}
					if (Main.LocalPlayer.ZoneJungle && !Main.LocalPlayer.ZoneRockLayerHeight)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");
						priority = MusicPriority.BiomeMedium;
					}
					if (Main.LocalPlayer.ZoneGlowshroom && !Main.LocalPlayer.ZoneRockLayerHeight)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/GlowingMushroom");
						priority = MusicPriority.BiomeMedium;
					}
					if (Main.LocalPlayer.ZoneCorrupt && Main.LocalPlayer.ZoneRockLayerHeight)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCorruption");
						priority = MusicPriority.BiomeMedium;
					}
					if (Main.LocalPlayer.ZoneCrimson && Main.LocalPlayer.ZoneRockLayerHeight)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCrimson");
						priority = MusicPriority.BiomeMedium;
					}
					if (Main.LocalPlayer.ZoneMeteor)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Meteor");
						priority = MusicPriority.BiomeMedium;
					}
					if ()
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Meteor");
						priority = MusicPriority.BiomeMedium;
					}
					int hellAlt = Main.rand.Next(1);
					if (Main.LocalPlayer.ZoneUnderworldHeight && hellAlt == 0)
					{
						music = MusicID.Eerie;
						priority = MusicPriority.BiomeMedium;
					}
					else if (Main.LocalPlayer.ZoneUnderworldHeight && hellAlt == 1)
					{
						music = MusicID.Hell;
						priority = MusicPriority.BiomeMedium;
					}
					/*
					//Marble
					if ()
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Marble");
						priority = MusicPriority.BiomeMedium;
					}
					//Granite
					if ()
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Granite");
						priority = MusicPriority.BiomeMedium;
					}
					*/
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
					//Events
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
					if (BirthdayParty.PartyIsUp)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/Party");
						priority = MusicPriority.Event;
					}
					if ()
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/FrostLegion");
						priority = MusicPriority.Event;
					}
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
	}
}