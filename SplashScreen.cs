using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{

    public GameObject animationRun;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ReturnToMenu());
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(.5f);
        animationRun.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }
}
