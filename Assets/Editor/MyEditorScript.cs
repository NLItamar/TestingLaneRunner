// C# example
using UnityEditor;

class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = {"Assets/Scenes/LaneRunner.unity" };
        BuildPipeline.BuildPlayer(scenes, "D:/testing2019/builds", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}