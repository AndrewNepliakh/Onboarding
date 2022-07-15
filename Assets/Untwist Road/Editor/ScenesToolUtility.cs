using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Untwist_Road.Editor
{
    public class ScenesToolUtility
    {
        [MenuItem("Scenes/Menu")] public static void MenuScene() => OpenEditorScene("Menu");
        [MenuItem("Scenes/Level_1")] public static void Level1Scene() => OpenEditorScene("Level_1");
        [MenuItem("Scenes/Level_2")] public static void Level2Scene() => OpenEditorScene("Level_2");
        [MenuItem("Scenes/Level_3")] public static void Level3Scene() => OpenEditorScene("Level_3");

        static void OpenEditorScene(string sceneName)
        {
            if (Application.isPlaying)
                return;

            EditorSceneManager.OpenScene(Application.dataPath + "/Untwist Road/Scenes/" + sceneName + ".unity");
        }
    }
}