using UnrealBuildTool;

public class FroggyFightersTarget : TargetRules
{
	public FroggyFightersTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FroggyFighters");
	}
}
