using UnrealBuildTool;

public class Team8Target : TargetRules
{
	public Team8Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Team8");
	}
}
