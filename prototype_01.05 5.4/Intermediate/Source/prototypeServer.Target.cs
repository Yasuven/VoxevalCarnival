using UnrealBuildTool;

public class prototypeServerTarget : TargetRules
{
	public prototypeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("prototype");
	}
}
