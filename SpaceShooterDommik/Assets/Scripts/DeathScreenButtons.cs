using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtons : MonoBehaviour
{
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
}
