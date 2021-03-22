using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public AudioSource LevelMusic;
    public GameObject PauseMenu;
    public AudioSource pauseSound;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!isPaused)
            {
                pauseSound.Play();
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                LevelMusic.Pause();
                PauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;
                Cursor.visible = false;
                LevelMusic.UnPause();
                PauseMenu.SetActive(false);
            }
        }
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        Cursor.visible = false;
        LevelMusic.UnPause();
        PauseMenu.SetActive(false);
    }

    public void restartLevel()
    {
        Time.timeScale = 1;
        isPaused = false;
        Cursor.visible = false;
        LevelMusic.UnPause();
        PauseMenu.SetActive(false);
        SceneManager.LoadScene(2);
    }

    public void toMenu()
    {
        Time.timeScale = 1;
        isPaused = false;
        Cursor.visible = false;
        LevelMusic.UnPause();
        PauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
