using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EDAT
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Label(Language.GetTextValue("Mods.EDAT.Common.UndergroundCorruptionThemeLabel"))]
		[Tooltip(Language.GetTextValue("Mods.EDAT.Common.UndergroundCorruptionThemeTooltip"))]
		[DefaultValue(true)]
		public bool UndergroundCorruptionTheme;

		[Label(Language.GetTextValue("Mods.EDAT.Common.UndergroundCrimsonThemeLabel"))]
		[Tooltip(Language.GetTextValue("Mods.EDAT.Common.UndergroundCrimsonThemeTooltip"))]
		[DefaultValue(true)]
		public bool UndergroundCrimsonTheme;
	}
}