using UnrealBuildTool;

public class practice362EditorTarget : TargetRules
{
	public practice362EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("practice362");
	}
}
