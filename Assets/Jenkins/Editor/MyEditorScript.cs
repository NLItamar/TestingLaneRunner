// C# example
using UnityEditor;

class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = {"Assets/Scenes/TestingLaneRunner.unity" };
        BuildPipeline.BuildPlayer(scenes, "D:/testing2019/builds/game.exe", BuildTarget.StandaloneWindows64, BuildOptions.CompressWithLz4);
    }
}