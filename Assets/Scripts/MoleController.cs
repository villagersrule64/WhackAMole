using System.Collections;
using UnityEngine;

public class MoleController : MonoBehaviour
{
    [SerializeField]
    private float _minDelay = 1;
    [SerializeField]
    private float _maxDelay = 6;
    [SerializeField]
    private int _timesToClick = 1;
    [SerializeField]
    private int _scoreAmount = 1;

    private int _timesClicked = 0;

    void Start()
    {
        StartCoroutine(WillMove());
    }

    private IEnumerator WillMove()
    {
        var animator = GetComponent<Animator>();
        float delay = Random.Range(_minDelay, _maxDelay);
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
        var anim = GetComponent<Animator>();
        _timesClicked++;

        if (_timesClicked >= _timesToClick)
        {
            GameManager.ChangeScore(_scoreAmount);
            anim.SetTrigger("Clicked");
            _timesClicked = 0;
        }
    }
}