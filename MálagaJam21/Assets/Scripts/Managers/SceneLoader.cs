using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scene
    {
        GameScene,
        MainMenuScene
    }

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}