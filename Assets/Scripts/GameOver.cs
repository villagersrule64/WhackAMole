using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    private void Start()
    {
        _scoreText.text = "Score: " + GameManager.Score;
    }
}
