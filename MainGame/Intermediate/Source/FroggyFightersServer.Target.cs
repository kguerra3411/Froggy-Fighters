using UnrealBuildTool;

public class FroggyFightersServerTarget : TargetRules
{
	public FroggyFightersServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FroggyFighters");
	}
}
