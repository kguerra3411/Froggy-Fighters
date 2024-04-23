using UnrealBuildTool;

public class practice362ServerTarget : TargetRules
{
	public practice362ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("practice362");
	}
}
