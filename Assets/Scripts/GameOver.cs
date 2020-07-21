using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + GameScore.Score;
    }
}
