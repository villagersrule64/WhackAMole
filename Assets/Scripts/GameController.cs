using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public Text scoreText;
    [SerializeField]
    private Text timeText;
    private int time = 30;

    public void ChangeScore(int change)
    {
        GameScore.Score += change;
        if (GameScore.Score <= 0)
            GameScore.Score = 0;
        scoreText.text = GameScore.Score.ToString();
    }

    private void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (time != 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            timeText.text = time.ToString();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
