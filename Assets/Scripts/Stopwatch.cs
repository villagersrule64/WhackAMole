using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    [SerializeField]
    private Color _red;

    private void Start()
    {
        StartCoroutine(CheckTime());
    }

    private IEnumerator CheckTime()
    {
        yield return new WaitForSeconds(0.1f);
        //while (GameManager.Time != 0)
        //{
        //    if (GameManager.Time <= 10)
        //        GetComponent<RawImage>().color = _red;
        //    if (GameManager.Time <= 5)
        //    {
        //        transform.rotation = Quaternion.Euler(0, 0, -30);
        //        yield return new WaitForSeconds(0.2f);
        //        transform.rotation = Quaternion.Euler(0, 0, 30);
        //        yield return new WaitForSeconds(0.2f);
        //        transform.rotation = Quaternion.Euler(0, 0, -30);
        //        yield return new WaitForSeconds(0.2f);
        //        transform.rotation = Quaternion.Euler(0, 0, 30);
        //        yield return new WaitForSeconds(0.2f);
        //        transform.rotation = Quaternion.Euler(0, 0, 0);
        //        yield return new WaitForSeconds(1);
        //    }
        //}
    }
}
