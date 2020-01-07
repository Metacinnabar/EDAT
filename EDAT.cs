using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EDAT
{
	public class EDAT : Mod
	{
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.musicVolume != 0)
			{
				if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
				{
					if (NPC.AnyNPCs(NPCID.EyeofCthulhu))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu");
						priority = MusicPriority.BossHigh;
					}
					/*
					if (NPC.AnyNPCs(NPCID.QueenBee))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/StingingOnslaught");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.DukeFishron))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/HellOrHighWaters");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.KingSlime))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/GelatineThrone");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism) || NPC.AnyNPCs(NPCID.TheDestroyer) || NPC.AnyNPCs(NPCID.SkeletronPrime))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/PlayingWithFirepower");
						priority = MusicPriority.BossHigh;
					}
					if (Main.raining && Main.LocalPlayer.ZoneSnow && !Main.LocalPlayer.ZoneRockLayerHeight)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/ColdFront");
						priority = MusicPriority.Event;
					}
					if (Main.LocalPlayer.ZoneMeteor)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/ViolenceOfSpace");
						priority = MusicPriority.BiomeMedium;
					}
					if (NPC.AnyNPCs(NPCID.EaterofWorldsHead))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/EvilEarthquake");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.BrainofCthulhu))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/CrimsonCortex");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.WallofFlesh) && Main.npc[NPC.FindFirstNPC(NPCID.WallofFlesh)].Distance(Main.LocalPlayer.Center) <= 5000)
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/PurgatorysAssault");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.CultistBoss))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/BreakingTheSeal");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.SkeletronHead))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/CurseOfTheDungeon");
						priority = MusicPriority.BossHigh;
					}
					if (NPC.AnyNPCs(NPCID.Golem))
					{
						music = GetSoundSlot(SoundType.Music, "Sounds/Music/FieryFistsOfStone");
						priority = MusicPriority.BossHigh;
					}*/
				}
			}
		}
	}
}