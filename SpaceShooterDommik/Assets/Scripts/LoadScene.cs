using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKey(KeyCode.R))
      {
        SceneManager.LoadScene("Game");
      }
      if(Input.GetKey(KeyCode.P))
      {
        PlayerPrefs.SetInt("Highscore", 0);
      }
    }
}
