using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtons : MonoBehaviour
{   
  public GameObject Header;
  public GameObject Content;
  public GameObject DeathScreen;
  public GameObject bg;
  public GameObject settings;
    public void RestartButton()
    {
      SceneManager.LoadScene("Game");
      UnityEngine.Cursor.visible = false;
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
    public void LeaderboardButton()
    {
      Header.SetActive(true);
      Content.SetActive(true);
      DeathScreen.SetActive(false);
      bg.SetActive(true);
    }
    public void SettingsButton()
    {
      settings.SetActive(true);
      DeathScreen.SetActive(false);
    }
}
