// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GameDesTestProj : ModuleRules
{
	public GameDesTestProj(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GameDesTestProj",
			"GameDesTestProj/Variant_Horror",
			"GameDesTestProj/Variant_Horror/UI",
			"GameDesTestProj/Variant_Shooter",
			"GameDesTestProj/Variant_Shooter/AI",
			"GameDesTestProj/Variant_Shooter/UI",
			"GameDesTestProj/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
