using UnrealBuildTool;

public class WorkshopTarget : TargetRules
{
	public WorkshopTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Workshop");
	}
}
