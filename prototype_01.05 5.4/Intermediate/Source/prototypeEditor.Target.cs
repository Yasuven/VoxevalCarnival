using UnrealBuildTool;

public class prototypeEditorTarget : TargetRules
{
	public prototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("prototype");
	}
}
