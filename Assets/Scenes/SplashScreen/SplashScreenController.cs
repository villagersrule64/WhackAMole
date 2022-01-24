using System.Collections;
using UnityEngine;

public class SplashScreenController : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ShowSplashScreen());
    }

    private IEnumerator ShowSplashScreen()
    {
        yield return new WaitForSeconds(3.6f);
        GameManager.LoadScene(SceneEnum.Home);
    }
}
