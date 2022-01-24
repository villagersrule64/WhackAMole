using UnityEngine;

public class SceneController: MonoBehaviour
{
    public void LoadHome()
    {
        GameManager.LoadScene(SceneEnum.Home);
    }

    public void LoadHowToPlay()
    {
        GameManager.LoadScene(SceneEnum.HowToPlay);
    }

    public void LoadModeChooser()
    {
        GameManager.LoadScene(SceneEnum.ModeChooser);
    }

    public void LoadGame()
    {
        GameManager.LoadScene(SceneEnum.Classic);
    }

    public void LoadHard()
    {
        GameManager.LoadScene(SceneEnum.Challenge);
    }

    public void LoadGameOver()
    {
        GameManager.LoadScene(SceneEnum.GameOver);
    }
}