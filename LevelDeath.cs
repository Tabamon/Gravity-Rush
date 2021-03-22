using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject GameMusic;
    public GameObject youFell;
    public GameObject deathSound;

    //if player falls play sound display message and reload current scene
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ThirdPersonController_LITE")
            StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        GameMusic.SetActive(false);
        deathSound.SetActive(true);
        yield return new WaitForSeconds(8);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectLevel.redirectToLevel);
    }
}
