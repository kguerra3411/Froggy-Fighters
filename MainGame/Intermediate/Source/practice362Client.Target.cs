using UnrealBuildTool;

public class practice362ClientTarget : TargetRules
{
	public practice362ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("practice362");
	}
}
