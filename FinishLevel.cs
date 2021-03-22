using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject score;
    public GameObject totalScore;
    public GameObject playerBlocker;
    public int timeCalc;
    public GameObject fadeOut;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        blockPlayer();
        int finalScore = calculateScore(GlobalTimer.extendScore, GlobalScore.currentScore);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " X 100";
        score.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScore.GetComponent<Text>().text = "Total Score: " + finalScore;
        if (finalScore > PlayerPrefs.GetInt("LevelScore", finalScore))
            PlayerPrefs.SetInt("LevelScore", finalScore);
        StartCoroutine(ScoreDisplayer());
    }

    IEnumerator ScoreDisplayer()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(.75f);
        score.SetActive(true);
        yield return new WaitForSeconds(.75f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectLevel.nextLevel);
    }

    int calculateScore(int timeLeft, int currentScore)
    {
        int result = timeLeft * 100 + currentScore;
        return result;
    }

    void blockPlayer()
    {
        playerBlocker.SetActive(true);
        playerBlocker.transform.parent = null;
    }
}
