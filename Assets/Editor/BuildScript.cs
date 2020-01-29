using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript : MonoBehaviour
{

    public static void Build()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Roll-a-ball.unity" };
        buildPlayerOptions.target = BuildTarget.StandaloneLinuxUniversal;
        buildPlayerOptions.locationPathName = "../build/linux_rollaball_build";
        buildPlayerOptions.options = BuildOptions.None;

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
