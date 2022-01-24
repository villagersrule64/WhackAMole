using System.Collections;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private TextMeshProUGUI _timeText;
    [SerializeField]
    private SceneController _sceneController;

    public void UpdateScore()
    {
        _scoreText.text = GameManager.Score.ToString();
    }

    private void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        GameManager.Time = 30;
        while (GameManager.Time != 0)
        {
            yield return new WaitForSeconds(1);
            GameManager.Time--;
            _timeText.text = GameManager.Time.ToString();
        }
        _sceneController.LoadGameOver();
    }
}
