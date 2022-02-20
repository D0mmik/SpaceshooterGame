using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{   public GameObject leaderboard;
    public GameObject settings;
    public Slider volumeSlider;
    public GameObject buttonsUI;
    void Awake() 
    {
       Application.targetFrameRate = 240;
    }
    public void PlayButton()
    {
      SceneManager.LoadScene("Game");
      Time.timeScale = 1f;
    }
    public void SettingsButton()
    {
        settings.SetActive(true);
        buttonsUI.SetActive(false);
    }
    public void LeaderboardButton()
    {
        leaderboard.SetActive(true);
        buttonsUI.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SaveSlider()
    {
      PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
      buttonsUI.SetActive(false);
      SceneManager.LoadScene("Menu");
    }

}
