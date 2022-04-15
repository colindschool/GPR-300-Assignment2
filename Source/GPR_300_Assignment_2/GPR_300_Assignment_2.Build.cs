// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GPR_300_Assignment_2 : ModuleRules
{
	public GPR_300_Assignment_2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
