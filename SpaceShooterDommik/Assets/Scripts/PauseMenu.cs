using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{   public static bool isPaused = false;
    public GameObject Menu;
    public GameObject DeathScreen;
    public GameObject settings;
    public GameObject leaderboard;
    
    public GameObject nickname;
    public AudioSource Music;
    public Slider volumeSlider;
    public GameObject scoretext;

    void Start()
    {
        isPaused = false;
        Menu.SetActive(false);

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && DeathScreen.activeSelf == false && leaderboard.activeSelf == false && settings.activeSelf == false)
        {
            if(isPaused)
            {
                Resume();
                             
            }
            else
            {
                Pause();
                UnityEngine.Cursor.visible = true;  
            }
        }

        if(Input.GetKey(KeyCode.R) && nickname.activeSelf == false)
        {
          SceneManager.LoadScene("Game");
          Time.timeScale = 1f;      
        }
        if(Input.GetKey(KeyCode.P) && nickname.activeSelf == false)
        {
        PlayerPrefs.SetInt("Highscore", 0);
        }

        if(isPaused || DeathScreen.activeSelf == true || settings.activeSelf == true || leaderboard.activeSelf == true || nickname.activeSelf == true)
            {
                UnityEngine.Cursor.visible = true;              
            }
            else
            {
                UnityEngine.Cursor.visible = false;
            }
        }
    public void Resume()
    {
      Menu.SetActive(false);
      Time.timeScale = 1f;
      isPaused = false; 
      Music.UnPause();
    }
    void Pause()
    {
      Menu.SetActive(true);
      Time.timeScale = 0f;
      isPaused = true;
      Music.Pause(); 
    }
    public void ContinueButton()
    {
        Resume();
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("quit1");
    }
    public void BackButton()  //deathscreen
    {
       DeathScreen.SetActive(true);
       leaderboard.SetActive(false);
       scoretext.SetActive(true);
    }
    public void BackButtonSlider()  //settings
    {
       PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
       DeathScreen.SetActive(true);
       settings.SetActive(false);
       scoretext.SetActive(true);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
