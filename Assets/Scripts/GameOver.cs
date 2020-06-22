using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + GameScore.Score;
    }
}
