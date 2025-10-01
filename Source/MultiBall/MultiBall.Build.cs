// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MultiBall : ModuleRules
{
	public MultiBall(ReadOnlyTargetRules Target) : base(Target)
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
			"MultiBall",
			"MultiBall/Variant_Platforming",
			"MultiBall/Variant_Platforming/Animation",
			"MultiBall/Variant_Combat",
			"MultiBall/Variant_Combat/AI",
			"MultiBall/Variant_Combat/Animation",
			"MultiBall/Variant_Combat/Gameplay",
			"MultiBall/Variant_Combat/Interfaces",
			"MultiBall/Variant_Combat/UI",
			"MultiBall/Variant_SideScrolling",
			"MultiBall/Variant_SideScrolling/AI",
			"MultiBall/Variant_SideScrolling/Gameplay",
			"MultiBall/Variant_SideScrolling/Interfaces",
			"MultiBall/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
