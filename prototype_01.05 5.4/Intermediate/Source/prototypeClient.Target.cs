using UnrealBuildTool;

public class prototypeClientTarget : TargetRules
{
	public prototypeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("prototype");
	}
}
