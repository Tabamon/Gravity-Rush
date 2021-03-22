using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunctions : MonoBehaviour
{

    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best Score: " + bestScore;
    }

    public void playGame()
    {
        buttonPress.Play();
        RedirectLevel.redirectToLevel = 3;
        SceneManager.LoadScene(3);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }

    public void resetScore()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best Score: " + bestScore;
    }
}
