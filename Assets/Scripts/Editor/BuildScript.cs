using UnityEngine;
using UnityEditor;

public static class BuildScript {
    public static void PerformScriptOnlyBuild() {
        // Perform any necessary build operations using only scripts
        // This could include setting build flags, loading scenes, etc.
        
        // Perform the actual build
        BuildPipeline.BuildPlayer(new string[] { }, "Builds/ScriptOnlyBuild", BuildTarget.Android, BuildOptions.BuildScriptsOnly);
    }
}