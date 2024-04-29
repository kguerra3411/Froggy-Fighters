using UnrealBuildTool;

public class FroggyFightersEditorTarget : TargetRules
{
	public FroggyFightersEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FroggyFighters");
	}
}
