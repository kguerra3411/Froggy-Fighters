using UnrealBuildTool;

public class FroggyFightersClientTarget : TargetRules
{
	public FroggyFightersClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FroggyFighters");
	}
}
