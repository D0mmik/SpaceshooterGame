using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtons : MonoBehaviour
{   
  public GameObject Leaderboard;
  public GameObject DeathScreen;
  public GameObject settings;
  public GameObject scoretext;
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
      Leaderboard.SetActive(true);
      DeathScreen.SetActive(false);
      scoretext.SetActive(false);
    }
    public void SettingsButton()
    {
      settings.SetActive(true);
      DeathScreen.SetActive(false);
      scoretext.SetActive(false);
    }
}
