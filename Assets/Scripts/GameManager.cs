using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneEnum
{
    Home,
    HowToPlay,
    ModeChooser,
    Classic,
    Challenge,
    GameOver
}

public static class GameManager
{
    public static int Score { get; set; }
    public static int Time { get; set; }

    

    public static void ChangeScore(int change)
    {
        Score += change;
        if (Score <= 0)
            Score = 0;
        Object.FindObjectOfType<LevelController>().UpdateScore();
    }

    public static void LoadScene(SceneEnum sceneEnum)
    {
        var scenePath = ScenePath[sceneEnum];
        SceneManager.LoadScene(scenePath);
    }

    public static Dictionary<SceneEnum, string> ScenePath = new Dictionary<SceneEnum, string>
    {
        { SceneEnum.Home, "Scenes/Start Menu" },
        { SceneEnum.HowToPlay, "Scenes/How To Play" },
        { SceneEnum.ModeChooser, "Scenes/Mode Chooser" },
        { SceneEnum.Classic, "Scenes/Game" },
        { SceneEnum.Challenge, "Scenes/Challenge" },
        { SceneEnum.GameOver, "Scenes/Game Over" },
    };
}
