using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectLevel : MonoBehaviour
{
    public static int redirectToLevel = 2;
    public static int nextLevel;

    // Update is called once per frame
    void Update()
    {
        if (redirectToLevel == 2)
        {
            SceneManager.LoadScene(redirectToLevel);
        }
    }
}
