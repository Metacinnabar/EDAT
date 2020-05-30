using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EDAT
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Label("Underground Corruption's Theme Change")]
		[Tooltip("True to change Underground Corruption's theme. This is a config option because it's the only biome that uses the vanilla underground corruption theme. True will have NO biomes play underground corruption, false will have the underground corruption play vanilla underground corruption")]
		[DefaultValue(true)]
		public bool UndergroundCorruptionTheme;

		[Label("Underground Crimson's Theme Change")]
		[Tooltip("True to change Underground Crimson's theme. This is a config option because it's the only biome that uses the vanilla underground crimson theme. True will have NO biomes play underground crimson, false will have the underground crimson play vanilla underground crimson")]
		[DefaultValue(true)]
		public bool UndergroundCrimsonTheme;
	}
}