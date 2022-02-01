using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   public static bool isPaused = false;
    public GameObject Menu;
    public GameObject DeathScreen;
    public AudioSource Music;

    void Start()
    {
        isPaused = false;
        Menu.SetActive(false);

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && DeathScreen.activeSelf == false)
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

        if(Input.GetKey(KeyCode.R))
        {
          SceneManager.LoadScene("Game");
          Time.timeScale = 1f;
          
        }

        if(isPaused || DeathScreen.activeSelf == true)
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
}
