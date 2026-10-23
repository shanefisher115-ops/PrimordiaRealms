using UnrealBuildTool;

public class PrimordiaRealms : ModuleRules
{
    public PrimordiaRealms(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "Json",
            "JsonUtilities",
            "Networking",
            "Sockets"
        });

        PrivateDependencyModuleNames.AddRange(new string[] { });
    }
}
