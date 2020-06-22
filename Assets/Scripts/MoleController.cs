using System.Collections;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    private GameController _gameController;
    void Start()
    {
        _gameController = FindObjectOfType<GameController>();
        StartCoroutine(WillMove());
    }

    private IEnumerator WillMove()
    {
        var animator = GetComponent<Animator>();
        int delay = Random.Range(1, 6);
        float untilDown = Random.Range(0.3f, 0.8f);

        while (true)
        {
            yield return new WaitForSeconds(delay);
            var rnd = Random.Range(0, 1f);
            if (rnd < untilDown)
            {
                animator.SetTrigger("Up");
            }
        }
    }

    private void OnMouseDown()
    {
        _gameController.ChangeScore(1);
        var anim = GetComponent<Animator>();
        anim.SetTrigger("Clicked");
    }
}