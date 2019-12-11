// C# example
using UnityEditor;

class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = {"Assets/Scenes/LaneRunner.unity" };
        BuildPipeline.BuildPlayer(scenes, "D:/testing2019/builds/game.exe", BuildTarget.StandaloneWindows, BuildOptions.CompressWithLz4);
    }
}