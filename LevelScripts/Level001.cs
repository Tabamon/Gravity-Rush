using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        RedirectLevel.redirectToLevel = 3;
        RedirectLevel.nextLevel = 5;
        StartCoroutine(fadeInOff());
    }

    IEnumerator fadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
