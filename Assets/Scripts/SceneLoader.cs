using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Scene(int num)
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex + num;
        SceneManager.LoadScene(sceneIndex);
        if (num == -1 || num == -3)
            GameScore.Score = 0;
    }
}