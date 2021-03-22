using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCredits : MonoBehaviour
{

    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RollCredits());
    }

    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(0.5f);
        credits.SetActive(true);
        yield return new WaitForSeconds(7.5f);
        SceneManager.LoadScene(1);
    }
}
